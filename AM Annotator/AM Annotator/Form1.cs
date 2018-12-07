using System;
using System.Collections.Generic;
using System.IO;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.Util;
using Emgu.CV.Structure;
using System.Xml;
using System.Threading;
using System.Diagnostics;

namespace AM_Annotator
{
    public partial class mainWindow : Form
    {
        Emgu.CV.Tracking.TrackerTLD csrt_tracker = new Emgu.CV.Tracking.TrackerTLD();
        Thread auto_save_thread;

        Mat selected_img = new Mat();

        private List<string> supported_img_format = new List<string>{ "jpg", "jpeg", "png", "gif", "tiff", "bmp" };
        private List<AnnotationImage> annotation_imgs = new List<AnnotationImage>();
        private AnnotationImage selected_annotation_img = new AnnotationImage();
        private FeatureLabel current_annotation = new FeatureLabel();

        private Point mouse_start_position = new Point();
        private Point mouse_current_position = new Point();

        private string last_openned_directory = @"C:\";
        private string output_directory = @"C:\";
        private string project_path = "Untitled";
        private string temp_workspace = "";

        private double annotation_padding = 0.1;

        private int selected_annotation_index = -1;
        private int selected_label_index = -1;
        private int annotation_font_size = 12;
        private int tracker_reference_class_id = 0;



        private bool annotation_selected = false;
        private bool multi_annotation_view = false;
        private bool mouseIsDown = false;
        private bool use_tracker = false;
        private bool use_feature_descriptor = false;

        private Thread SplashThread;
        public mainWindow(bool runSplash = true)
        {

            if (runSplash)
            {
                SplashThread = new Thread(new ThreadStart(StartSplash));
                SplashThread.Start();
                Thread.Sleep(5000);
            }
            else
            {
                Properties.Settings.Default.Reset();
            }
            InitializeComponent();

            if (runSplash)
            {
                SplashThread.Abort();
            }
        }

        public void StartSplash()
        {
            Application.Run(new SplashForm());
        }

        private void mainWindow_Load(object sender, EventArgs e)
        {

            assistantMethodCB.SelectedIndex = 0;

            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(Screen.PrimaryScreen.Bounds.Width / 5, Screen.PrimaryScreen.Bounds.Height / 5);
            this.BringToFront();
            //this.TopMost = true;

            //Properties.Settings.Default.ProjectLocation = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\Annotator\\" + DateTime.Now.ToString("MM.dd.yyyy") + "_" + DateTime.Now.ToString("HH-mm");
            //Directory.CreateDirectory(Properties.Settings.Default.ProjectLocation);
            //openProjectBTN.Text = Properties.Settings.Default.ProjectLocation;
            this.Text = project_path;

            annotatorProjectBTN.Enabled = false;
            //Setting up AutoSave Thread
            temp_workspace = System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments) + "\\Annotator\\temp_workspace.am";

            //auto_save_thread = new Thread(AutoSave);
            //auto_save_thread.IsBackground = true;
            //auto_save_thread.Start();

        }

        //AutoSave Thread
        private void AutoSave()
        {
            while (auto_save_thread.IsAlive)
            {
                SaveConfiguration(temp_workspace);
                Thread.Sleep(Properties.Settings.Default.AutoSaveInterval * 1000);
            }
            
        }

        /********************************This is where the load button is pressed*******************************/
        /*
         * Actions: 
         * Reading the directory
         * Recording the directory if it is not repeated
         * Adding all the images to the list of AnnotationImages
         */
        private void loadBTN_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog openDir = new FolderBrowserDialog();
            openDir.SelectedPath = last_openned_directory;

            if (openDir.ShowDialog() == DialogResult.OK && !string.IsNullOrWhiteSpace(openDir.SelectedPath))
            {
                //thread
                Thread load_thread = new Thread(() => LoadProcess(openDir.SelectedPath));
                load_thread.IsBackground = true;
                load_thread.Start();
                //load_thread.Join();
                //load_thread.Abort();

                
            }
        }

        private void LoadProcess(string path)
        {
            this.Invoke((MethodInvoker) delegate
            {
                /*if the directory is not added already*/
                if (!annotation_imgs.Any(x => x.GetParentPath() == path))
                {
                    /*If it contains any image*/
                    if (loadImages(path) > 0)
                    {
                        last_openned_directory = path;
                        updateFolderListBox();
                        folderLB.SelectedIndex = 0;
                        AlertUnsavedProject(false);
                    }
                }
            });
            
        }

        /*******************************Loading the Images given the directory*********************/
        /*
         * The assumption is that we know for sure that the passed directory has not been processed before
         */
        private int loadImages(string directory)
        {

            int img_cnt = 0;
            /*looking into the target directory for every hardcoded image format*/
            for(int i = 0; i < supported_img_format.Count; i++) 
            {
                var files = Directory.GetFiles(directory, "*." + supported_img_format[i], SearchOption.TopDirectoryOnly);
                foreach (string file in files)
                {
                    annotation_imgs.Add(new AnnotationImage(file));
                }
                loadImageProgressBar.Value = (int)(i * 100.0 / supported_img_format.Count);
                img_cnt += files.Count();
            }
            loadImageProgressBar.Value = loadImageProgressBar.Maximum;
            return img_cnt;

        }

        private void updateFolderListBox()
        {
            folderLB.Items.Clear();
            foreach (AnnotationImage ai in annotation_imgs)
            {
                if (!folderLB.Items.Contains(ai.GetParentPath()))
                {
                    folderLB.Items.Add(ai.GetParentPath());
                }
            }
            
        }

        /// <summary>
        /// Given s parent folder, this routine looks into the annotation_imgs and list them in the imageLB
        /// if they have the same parent folder
        /// </summary>
        /// <param name="parent_folder">string that indicates the target parent folder</param>
        private void updateImgListBox(string parent_folder)
        {
            //Clear the imageLB item
            imageLB.Items.Clear();
            /*foreach (string s in current_directory_img_list)
            {
                imageLB.Items.Add(s);
            }*/
            //Iterating through the annotation_imgs
            foreach (AnnotationImage ai in annotation_imgs)
            {
                string parent = ai.GetParentPath();
                if (parent == parent_folder)
                {
                    imageLB.Items.Add(ai.GetFileName());
                }
            }
        }
        /*folderLB item selection event*/
        private void folderLB_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {
                string selected_directory = folderLB.SelectedItem.ToString();
                

                updateImgListBox(folderLB.SelectedItem.ToString());
                if (imageLB.Items.Count > 0)
                {
                    imageLB.SelectedIndex = 0;
                }
            }
            catch (NullReferenceException nre)
            {
            }
            
        }

        /****************************************When an image is selected in the image list box*********************************************/
        /*
         * The assumption is that images in the list box are already pre-processed and there is an AnnotationImage object for the 
         * selected image in the project AnnotationImage list
         */
        private void imageLB_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //Form the string related to image location
                string image_path = folderLB.SelectedItem.ToString() + "\\" + imageLB.SelectedItem.ToString();

                /*getting the image based on the selected item text*/
                //selected_annotation_img = getImage(imageLB.SelectedItem.ToString());
                selected_annotation_index = getImageIndex(image_path);

                /*loading and resizing the image*/
                selected_img = annotation_imgs[selected_annotation_index].GetMat();

                int coef = 1;
                if (selected_img.Width > mainPB.Width)
                {
                    coef = Math.Max(coef, (int)((selected_img.Height / (mainPB.Height * 1.0)) + 1.0));
                }
                if (selected_img.Height > mainPB.Height)
                {
                    coef = Math.Max(coef, (int)((selected_img.Height / (mainPB.Height * 1.0)) + 1.0));                   
                }


                CvInvoke.Resize(selected_img, selected_img, new Size(selected_img.Width / coef, selected_img.Height / coef));
                Image<Bgr, Byte> my_image = selected_img.ToImage<Bgr, byte>();
                mainPB.Image = my_image.ToBitmap();

                if (use_tracker && annotation_imgs[selected_annotation_index].GetLabels().Count <= 1)
                {
                    Rectangle roi = new Rectangle();
                    if (csrt_tracker.Update(selected_img, out roi))
                    {
                        csrt_tracker.Init(selected_img, roi);
                        annotation_imgs[selected_annotation_index].AddLabel(tracker_reference_class_id, roi.X, roi.Y, roi.Width, roi.Height);
                    }
                }

                /*updating the annotation ListBox*/
                updateAnnotationLB();
            }
            catch (ArgumentException E)
            {

            }
           
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void removeBTN_Click(object sender, EventArgs e)
        {
            try
            {
                string selected_directory = folderLB.SelectedItem.ToString();
                if (selected_directory != "")
                {
                    //Selecting the ImageAnnotation objects whose parent paths are not the same as the selected directory
                    annotation_imgs = annotation_imgs.Where(x => x.GetParentPath() != selected_directory).ToList();
                    
                    updateFolderListBox();
                    imageLB.Items.Clear();
                   
                    mainPB.Image = null;
                    mainPB.Refresh();
                    AlertUnsavedProject(false);
                }
            }
            catch (NullReferenceException nre)
            {

            }
        }

        /***********************************Output Directory Set Button********************************************/
        private void setBTN_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog openDir = new FolderBrowserDialog();

            if (openDir.ShowDialog() == DialogResult.OK && !string.IsNullOrWhiteSpace(openDir.SelectedPath))
            {
                output_directory = openDir.SelectedPath;
                //outputDirectoryTB.Text = openDir.SelectedPath;
            }
        }

        private void mainPB_MouseDown(object sender, MouseEventArgs e)
        {
            if (mainPB.Image == null)
            {
                return;
            }
            if (e.X > mainPB.Image.Width || e.Y > mainPB.Image.Height)
            {
                return;
            }
            mouse_start_position.X = e.X;
            mouse_start_position.Y = e.Y;
            mouseIsDown = true;
            mainPB.Invalidate();

            /*Updating the Label Info about the annotation*/
            lastAnnotationXL.Text = mouse_start_position.X.ToString();
            lastAnnotationYL.Text = mouse_start_position.Y.ToString();
        }

        private void mainPB_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseIsDown)
            {
                mouse_current_position.X = e.X;
                mouse_current_position.Y = e.Y;
                mainPB.Invalidate();
            }

            cursorPositionXL.Text = e.X.ToString();
            cursorPositionYL.Text = e.Y.ToString();


            try
            {
                /*Make sure that the draw is within the width and height of the image*/
                mouse_current_position.X = Math.Min(mouse_current_position.X, mainPB.Image.Width);
                mouse_current_position.Y = Math.Min(mouse_current_position.Y, mainPB.Image.Height);

                mouse_current_position.X = Math.Max(mouse_current_position.X, 0);
                mouse_current_position.Y = Math.Max(mouse_current_position.Y, 0);

                /*Updating the Label Info about the annotation*/
                lastAnnotationEndXL.Text = mouse_current_position.X.ToString();
                lastAnnotationEndYL.Text = mouse_current_position.Y.ToString();
                lastAnnotationWidthL.Text = Math.Abs(mouse_current_position.X - mouse_start_position.X).ToString();
                lastAnnotationHeightL.Text = Math.Abs(mouse_current_position.Y - mouse_start_position.Y).ToString();
            }
            catch (Exception ex)
            {

            }
            

        }

        /***********************************Event when mouse button is released***********************************/
        private void mainPB_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                mouse_current_position = e.Location;
                mouseIsDown = false;

                /*Updating the Annotation List for the Current Image*/

                /*Make sure that the draw is within the width and height of the image*/
                mouse_current_position.X = Math.Min(mouse_current_position.X, mainPB.Image.Width);
                mouse_current_position.Y = Math.Min(mouse_current_position.Y, mainPB.Image.Height);

                mouse_current_position.X = Math.Max(mouse_current_position.X, 0);
                mouse_current_position.Y = Math.Max(mouse_current_position.Y, 0);

                var x = Math.Min(mouse_current_position.X, mouse_start_position.X);
                var y = Math.Min(mouse_current_position.Y, mouse_start_position.Y);
                var width = Math.Abs(mouse_current_position.X - mouse_start_position.X);
                var height = Math.Abs(mouse_current_position.Y - mouse_start_position.Y);
                //FeatureLabel fl = new FeatureLabel();

                //Load the id window
                Form labelWindow = new labelForm();
                labelWindow.StartPosition = FormStartPosition.Manual;
                labelWindow.Location = new Point(this.Width / 2, this.Height / 2);
                if (labelWindow.ShowDialog() == DialogResult.OK)
                {
                    //int a = labelForm.LabelClass;
                    annotation_imgs[selected_annotation_index].AddLabel(labelForm.LabelClass, x, y, width, height);

                    //Update Gui
                    updateAnnotationLB();
                    viewAllAnnotationsBTN.PerformClick();
                    //currentImgAnnotationsLB.Items.Add(annotation_imgs[selected_annotation_index].ToString());
                    AlertUnsavedProject(false);

                    csrt_tracker = new Emgu.CV.Tracking.TrackerTLD();
                    csrt_tracker.Init(annotation_imgs[selected_annotation_index].GetMat(), new Rectangle(x, y, width, height));
                    tracker_reference_class_id = labelForm.LabelClass;


                }
            }
            catch (Exception ex)
            {
            }
            
        }
        /***********************************Picture Box Paint Event. Call it manually by mainPB.Invalidate()***********************************/
        private void mainPB_Paint(object sender, PaintEventArgs e)
        {
            if (mouseIsDown)
            {
                /*Make sure that the draw is within the width and height of the image*/
                mouse_current_position.X = Math.Min(mouse_current_position.X, mainPB.Image.Width);
                mouse_current_position.Y = Math.Min(mouse_current_position.Y, mainPB.Image.Height);

                mouse_current_position.X = Math.Max(mouse_current_position.X, 0);
                mouse_current_position.Y = Math.Max(mouse_current_position.Y, 0);

                var x = Math.Min(mouse_current_position.X, mouse_start_position.X);
                var y = Math.Min(mouse_current_position.Y, mouse_start_position.Y);
                var width = Math.Abs(mouse_current_position.X - mouse_start_position.X);
                var height = Math.Abs(mouse_current_position.Y - mouse_start_position.Y);
                /*Rectangle rect = new Rectangle(
                    Math.Min(mouse_current_position.X, mouse_start_position.X),
                    Math.Min(mouse_current_position.Y, mouse_start_position.Y),
                    Math.Abs(mouse_current_position.X - mouse_start_position.X),
                    Math.Abs(mouse_current_position.Y - mouse_start_position.Y));*/
                Rectangle rect = new Rectangle(x, y, width, height);

                Graphics g = e.Graphics;
                Pen pen = new Pen(Color.Red, 2);
                g.DrawRectangle(pen, rect);

                if (annotation_imgs[selected_annotation_index].GetLabels().Count > 0)
                {
                    Font drawFont = new Font("Arial", annotation_font_size);
                    SolidBrush drawBrush = new SolidBrush(Color.Red);
                    // Set format of string.
                    StringFormat drawFormat = new StringFormat();
                    drawFormat.FormatFlags = StringFormatFlags.DirectionRightToLeft;
                    foreach (FeatureLabel fl in annotation_imgs[selected_annotation_index].GetLabels())
                    {
                        g.DrawRectangle(pen, new Rectangle(fl.X, fl.Y, fl.Width, fl.Height));
                        g.DrawString(fl.Id.ToString(), drawFont, drawBrush, Convert.ToInt32(fl.End_X - fl.Width * annotation_padding), Convert.ToInt32(fl.Y + fl.Height * annotation_padding), drawFormat);
                    }
                }
                


                pen.Dispose();
            }
            else if (annotation_selected)
            {
                Rectangle rect = new Rectangle(annotation_imgs[selected_annotation_index].GetLabelAt(selected_label_index).X, 
                    annotation_imgs[selected_annotation_index].GetLabelAt(selected_label_index).Y, 
                    annotation_imgs[selected_annotation_index].GetLabelAt(selected_label_index).Width, 
                    annotation_imgs[selected_annotation_index].GetLabelAt(selected_label_index).Height);

                Graphics g = e.Graphics;
                Pen pen = new Pen(Color.Red, 2);
                g.DrawRectangle(pen, rect);


                // Create font and brush.
                Font drawFont = new Font("Arial", annotation_font_size,FontStyle.Bold);
                SolidBrush drawBrush = new SolidBrush(Color.Red);
                // Set format of string.
                StringFormat drawFormat = new StringFormat();
                drawFormat.FormatFlags = StringFormatFlags.DirectionRightToLeft;

                g.DrawString(annotation_imgs[selected_annotation_index].GetLabelAt(selected_label_index).Id.ToString(), drawFont, drawBrush,
                    annotation_imgs[selected_annotation_index].GetLabelAt(selected_label_index).End_X - Convert.ToInt32(annotation_imgs[selected_annotation_index].GetLabelAt(selected_label_index).Width * annotation_padding),
                    annotation_imgs[selected_annotation_index].GetLabelAt(selected_label_index).Y + Convert.ToInt32(annotation_imgs[selected_annotation_index].GetLabelAt(selected_label_index).Height * annotation_padding), drawFormat);
                pen.Dispose();
                annotation_selected = false;
            }
            else if (multi_annotation_view)
            {
                Graphics g = e.Graphics;
                Pen pen = new Pen(Color.Red, 2);
                // Create font and brush.
                Font drawFont = new Font("Arial", annotation_font_size);
                SolidBrush drawBrush = new SolidBrush(Color.Red);
                // Set format of string.
                StringFormat drawFormat = new StringFormat();
                drawFormat.FormatFlags = StringFormatFlags.DirectionRightToLeft;
                foreach (FeatureLabel fl in annotation_imgs[selected_annotation_index].GetLabels())
                {
                    g.DrawRectangle(pen, new Rectangle(fl.X, fl.Y, fl.Width, fl.Height));
                    g.DrawString(fl.Id.ToString(), drawFont, drawBrush, Convert.ToInt32(fl.End_X - fl.Width * annotation_padding), Convert.ToInt32(fl.Y + fl.Height * annotation_padding), drawFormat);
                }
                       
                pen.Dispose();

                multi_annotation_view = false;
            }
        }

        /***********************************Image Remove Button********************************************/
        private void imgRemoveBTN_Click(object sender, EventArgs e)
        {
            try
            {
                imageLB.Items.Remove(imageLB.SelectedItem);
                AlertUnsavedProject(false);
            }
            catch (Exception ex)
            {
            }
            if (imageLB.Items.Count > 0)
            {
                imageLB.SelectedIndex = 0;
            }
            else
            {
                mainPB.Image = null;
                mainPB.Refresh();
            }
            
        }

        //***********************************A callback when an annotation in the list is clicked/***********************************/
        private void currentImgAnnotationsLB_SelectedIndexChanged(object sender, EventArgs e)
        {
            selected_label_index = currentImgAnnotationsLB.SelectedIndex;
            //current_annotation = FeatureLabel.FromString(currentImgAnnotationsLB.Text);
            annotation_selected = true;
            mainPB.Invalidate();
        }

        /***********************************A callback when delete annotation button is clicked***********************************/
        private void deleteAnnotationBTN_Click(object sender, EventArgs e)
        {
            try
            {
                if (annotation_imgs[selected_annotation_index].GetLabels().Count > 0)
                {
                    annotation_imgs[selected_annotation_index].RemoveLabelAt(currentImgAnnotationsLB.SelectedIndex);
                    updateAnnotationLB();
                    AlertUnsavedProject(false);

                }
                if (annotation_imgs[selected_annotation_index].GetLabels().Count <= 0)
                {
                    imageLB.SetSelected(imageLB.SelectedIndex, true);
                    
                }
                
                              
            }
            catch (Exception ex)
            { 
            }
        }

        /***********************************Given a file location, return the feature label***********************************/
        private AnnotationImage getImage(string file_location)
        {
            return annotation_imgs.Find(img => img.GetImageLocation() == file_location);
        }
        /***********************************Given a file location, return the feature label index***********************************/
        private int getImageIndex(string file_location)
        {
            return annotation_imgs.FindIndex(img => img.GetImageLocation() == file_location);
        }

        /***********************************A routine to update the currentAnnotationLB based on the global selected annotation image***********************************/
        private void updateAnnotationLB()
        {
            currentImgAnnotationsLB.Items.Clear();
            foreach (string annotation in annotation_imgs[selected_annotation_index].GetAbsoluteString())
            {
                currentImgAnnotationsLB.Items.Add(annotation);
            }
            if (annotation_imgs.Count > 0 && annotation_imgs[selected_annotation_index].GetLabels().Count() > 0)
            {
                multi_annotation_view = true;
                mainPB.Invalidate();
            }
        }

        /***********************************A routine to view all annotations in the global index***********************************/
        private void viewAllAnnotationsBTN_Click(object sender, EventArgs e)
        {
            if (annotation_imgs.Count > 0 && annotation_imgs[selected_annotation_index].GetLabels().Count() > 0)
            {
                multi_annotation_view = true;
                mainPB.Invalidate();
            }
        }


        /***********************************When Preferences Button is pressed***********************************/
        private void preferencesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form settingForm = new SettingForm();
            settingForm.ShowDialog();
        }

        /***********************************Starting the Data Collection App***********************************/
        private void StartDataCollection()
        {
            Application.Run(new DataCollectionForm());
        }
        private void dataCollectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(StartDataCollection));
            t.SetApartmentState(System.Threading.ApartmentState.STA);
            t.Start();
            this.Close();
        }

        /************************************Saving The Entire Workspace when saveWorkspaceToolStripMenuItem is clicked***********************************/
        private void saveWorkspaceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (project_path.Contains("Untitled"))
            {
                SaveFileDialog save_window = new SaveFileDialog();
                save_window.Filter = "AM File|*.am";
                save_window.Title = "Save the Configurations";
                if (save_window.ShowDialog() == DialogResult.OK && save_window.FileName != "")
                {
                    SaveConfiguration(save_window.FileName);
                }
                project_path = save_window.FileName;
                return;
            }

            
            SaveConfiguration(project_path);



        }
        private void SaveConfiguration(string file_location)
        {
            //Setting up XMLWriter Object
            XmlWriterSettings writer_settings = new XmlWriterSettings();
            writer_settings.NewLineHandling = NewLineHandling.Replace;
            writer_settings.NewLineChars = Environment.NewLine;
            writer_settings.IndentChars = ("\t");
            writer_settings.Indent = true;
            writer_settings.ConformanceLevel = ConformanceLevel.Auto;
            XmlWriter writer;
            try
            {
                writer = XmlWriter.Create(file_location, writer_settings);
                //Writing the Components
                writer.WriteStartDocument();

                writer.WriteStartElement("Project");
                writer.WriteAttributeString("Name", Path.GetFileName(file_location));

                //Writing Project Setting
                writer.WriteStartElement("Setting");
                writer.WriteStartElement("Formats");

                writer.WriteAttributeString("Opencv", Convert.ToString(Properties.Settings.Default.OpencvAnnotation));
                writer.WriteAttributeString("Darknet", Convert.ToString(Properties.Settings.Default.DarknetAnnotation));
                writer.WriteAttributeString("Pascal", Convert.ToString(Properties.Settings.Default.PascalVOCAnnotation));

                writer.WriteEndElement();

                writer.WriteEndElement();

                //Writing The folder name
                foreach (string folder in folderLB.Items)
                {
                    writer.WriteStartElement("Folder");
                    writer.WriteAttributeString("Location", folder);

                    //Getting all the images that contains the parent folder
                    List<AnnotationImage> annotation_images = annotation_imgs.Where(x => x.GetImageLocation().Contains(folder)).ToList();

                    foreach (AnnotationImage annotation_image in annotation_images)
                    {
                        writer.WriteStartElement("Image");

                        writer.WriteAttributeString("Location", annotation_image.GetImageLocation());

                        List<FeatureLabel> labels = annotation_image.GetLabels();
                        foreach (FeatureLabel label in labels)
                        {
                            writer.WriteStartElement("Annotation");

                            writer.WriteAttributeString("Id", label.Id.ToString());

                            writer.WriteAttributeString("X", label.X.ToString());

                            writer.WriteAttributeString("Y", label.Y.ToString());

                            writer.WriteAttributeString("Width", label.Width.ToString());

                            writer.WriteAttributeString("Height", label.Height.ToString());

                            writer.WriteEndElement();
                        }

                        writer.WriteEndElement();
                    }



                    writer.WriteEndElement();
                }
                writer.WriteEndElement();
                writer.WriteEndDocument();


                //writer.Flush();
                writer.Close();
            }
            catch (Exception ex)
            {
            }
            

            

            AlertUnsavedProject(true);
        }
        /************************************Saving The Entire Workspace when newProjectToolStripMenuItem is clicked***********************************/
        private void newProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog open_window = new OpenFileDialog();
            open_window.InitialDirectory =  Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            open_window.Filter = "AM File|*.am";
            open_window.Title = "Choose AM Configuration Files";

            if (open_window.ShowDialog() == DialogResult.OK)
            {
                LoadConfiguration(open_window.FileName);
            }
        }
        private void LoadConfiguration(string file_location)
        {
            XmlReader reader = XmlReader.Create(file_location);

            reader.MoveToContent();
            AnnotationImage ai = new AnnotationImage();
            bool newAnnotationImage = false;
            while (reader.Read())
            {

                if (reader.NodeType == XmlNodeType.Element)
                {
                    if (reader.Name == "Formats")
                    {
                        Properties.Settings.Default.OpencvAnnotation = Convert.ToBoolean(reader.GetAttribute("Opencv"));
                        Properties.Settings.Default.DarknetAnnotation = Convert.ToBoolean(reader.GetAttribute("Darknet"));
                        Properties.Settings.Default.PascalVOCAnnotation = Convert.ToBoolean(reader.GetAttribute("Pascal"));
                    }
                    if (reader.Name == "Folder")
                    {
                        folderLB.Items.Add(reader.GetAttribute("Location"));                        
                    }
                    if (reader.Name == "Image")
                    {
                        ai = new AnnotationImage(reader.GetAttribute("Location"));
                        newAnnotationImage = true;
                    }
                    if (reader.Name == "Annotation")
                    {
                        ai.AddLabel(Convert.ToInt32(reader.GetAttribute("Id")), Convert.ToInt32(reader.GetAttribute("X")),
                            Convert.ToInt32(reader.GetAttribute("Y")), Convert.ToInt32(reader.GetAttribute("Width")),
                            Convert.ToInt32(reader.GetAttribute("Height")));
                        var s1 = ai.GetFileName();
                        var s2 = ai.GetParentFolder();
                        
                    }
                    if (newAnnotationImage)
                    {
                        annotation_imgs.Add(ai);
                        newAnnotationImage = false;
                    }
                }
            }

            updateFolderListBox();
        }

        /***********************************************Unsaved Alret Routine************************************************/
        private void AlertUnsavedProject(bool clearFlag)
        {
            this.Invoke((MethodInvoker) delegate
            {
                if (clearFlag)
                {
                    if (this.Text.Contains("*"))
                    {
                        this.Text = project_path;
                    }
                    return;
                }
                //if (!project_path.Contains("*"))
                if (!this.Text.Contains("*"))
                {
                    //project_path += "*";
                    this.Text = project_path + "*";
                }
            });
            
        }


        /***********************************************Build All Button************************************************/
        private void buildAllBTN_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.ProjectLocation == "")
            {
                MessageBox.Show("Please set the annotation folder in Edit -> Preferences.", "Unable to Build",  MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Form buildForm = new BuildForm(annotation_imgs, BUILD_LEVEL.BUILD_ALL);
            buildForm.ShowDialog();
        }
        /***********************************************Build Button************************************************/
        private void buildBTN_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.ProjectLocation == "")
            {
                MessageBox.Show("Please set the annotation folder in Edit -> Preferences.", "Unable to Build", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            bool buildPascal = Properties.Settings.Default.PascalVOCAnnotation;
            bool buildOpencv = Properties.Settings.Default.OpencvAnnotation;
            bool buildDarknet = Properties.Settings.Default.DarknetAnnotation;
            if (buildPascal && buildOpencv && buildDarknet)
            {
                Form buildForm = new BuildForm(annotation_imgs, BUILD_LEVEL.BUILD_ALL);
                buildForm.ShowDialog();
            }
            else if (buildPascal && !buildOpencv && !buildDarknet)
            {
                Form buildForm = new BuildForm(annotation_imgs, BUILD_LEVEL.BUILD_VOC_ONLY);
                buildForm.ShowDialog();
            }
            else if (!buildPascal && buildOpencv && !buildDarknet)
            {
                Form buildForm = new BuildForm(annotation_imgs, BUILD_LEVEL.BUILD_OPENCV_ONLY);
                buildForm.ShowDialog();
            }
            else if (!buildPascal && !buildOpencv && buildDarknet)
            {
                Form buildForm = new BuildForm(annotation_imgs, BUILD_LEVEL.BUILD_DARKNET_ONLY);
                buildForm.ShowDialog();
            }
        }

        private void projectBTN_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.ProjectLocation == "")
            {
                return;
            }
            Process.Start(Properties.Settings.Default.ProjectLocation);
        }

        private void StartMainWindow()
        {
            Application.Run(new mainWindow(false));
        }

        private void newWorkspaceBTN_Click(object sender, EventArgs e)
        {
            System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(StartMainWindow));
            t.SetApartmentState(System.Threading.ApartmentState.STA);
            t.Start();
            this.Close();
           
        }

        private void loadLastWorkspaceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (temp_workspace != "")// && File.Exists(temp_workspace))
            {
                LoadConfiguration(temp_workspace);
            }
        }

        private void mainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveConfiguration(temp_workspace);
        }

        /*private void useTrackerCB_MouseHover(object sender, EventArgs e)
        {
            ToolTip tip = new ToolTip();
            //tip.ToolTipTitle = "Alias Directory";
            //tip.Show("Path to the images in the training machine", this, 10);
            tip.SetToolTip(useTrackerCB, "Check this control to activate tracker assistant. Tracker assistant will assist in annotation of consecutive images.");
        }*/

        /*private void useTrackerCB_CheckedChanged(object sender, EventArgs e)
        {
            use_tracker = useTrackerCB.Checked;
        }*/

        private void deleteAllBTN_Click(object sender, EventArgs e)
        {
            if (annotation_imgs.Count == 0)
            {
                return;
            }
            annotation_imgs[selected_annotation_index].RemoveAllLabels();
            updateAnnotationLB();
            imageLB_SelectedIndexChanged(imageLB, EventArgs.Empty);
        }

        private void assistantMethodCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (assistantMethodCB.SelectedIndex)
            {
                case 0:
                    use_tracker = false;
                    use_feature_descriptor = false;
                    break;
                case 1:
                    use_tracker = true;
                    use_feature_descriptor = false;
                    break;
                case 2:
                    use_tracker = false;
                    use_feature_descriptor = true;
                    break;
            }
        }

        private void StartProjectOrganizer()
        {
            Application.Run(new ProjectOrganizerForm());
        }
        private void projectOrganizerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(StartProjectOrganizer));
            t.SetApartmentState(System.Threading.ApartmentState.STA);
            t.Start();
            this.Close();
        }
    }
}
