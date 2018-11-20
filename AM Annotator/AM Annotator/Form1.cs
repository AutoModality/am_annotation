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



namespace AM_Annotator
{
    public partial class mainWindow : Form
    {
        Mat selected_img = new Mat();

        private List<string> project_directory_list = new List<string>();
        private List<string> supported_img_format = new List<string>{ "jpg", "jpeg", "png", "gif", "tiff", "bmp" };
        private List<string> current_directory_img_list = new List<string>();
        private List<AnnotationImage> annotation_imgs = new List<AnnotationImage>();

        private FeatureLabel current_annotation = new FeatureLabel();

        private Point mouse_start_position = new Point();
        private Point mouse_current_position = new Point();

        private string last_openned_directory = @"C:\";
        private string output_directory = @"C:\";
        
        private bool annotation_selected = false;

        bool mouseIsDown = false;

        
        public mainWindow()
        {
            InitializeComponent();
        }

        private void mainWindow_Load(object sender, EventArgs e)
        {

        }

        private void loadBTN_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog openDir = new FolderBrowserDialog();
            openDir.SelectedPath = last_openned_directory;
            //openDir.InitialDirectory = last_openned_directory;
            //openDir.FilterIndex = 1;
            //openDir.RestoreDirectory = true;

            if (openDir.ShowDialog() == DialogResult.OK && !string.IsNullOrWhiteSpace(openDir.SelectedPath))
            {
                last_openned_directory = openDir.SelectedPath;
                if (!project_directory_list.Contains(last_openned_directory))
                {
                    project_directory_list.Add(last_openned_directory);
                    updateFolderListBox();
                    folderLB.SelectedIndex = 0;
                }
            }

            /*OpenFileDialog openFile = new OpenFileDialog();
            if (openFile.ShowDialog() == DialogResult.OK)
            {
               
                Mat frame = CvInvoke.Imread(openFile.FileName);

                int coef = 1;
                if (frame.Width > mainPB.Width)
                {
                    coef = (int)((frame.Width / mainPB.Width * 1.0) + 0.5);
                }
                if (frame.Height > mainPB.Height)
                {
                    coef = (int)((frame.Height / (mainPB.Height * 1.0)) +0.5); 
                }


                CvInvoke.Resize(frame, frame, new Size(frame.Width / coef, frame.Height / coef));
                Image<Bgr, Byte> my_image = frame.ToImage<Bgr, byte>();
                mainPB.Image = my_image.ToBitmap();
            }*/
        }

        private void updateFolderListBox()
        {
            folderLB.Items.Clear();
            foreach (string s in project_directory_list)
            {
                folderLB.Items.Add(s);
            }
        }
        private void updateImgListBox()
        {
            imageLB.Items.Clear();
            foreach (string s in current_directory_img_list)
            {
                imageLB.Items.Add(s);
            }
        }
        /*folderLB item selection event*/
        private void folderLB_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {
                string selected_directory = folderLB.SelectedItem.ToString();
                current_directory_img_list.Clear();
                foreach (string img_format in supported_img_format)
                {
                    current_directory_img_list.AddRange(Directory.GetFiles(selected_directory, "*." + img_format, SearchOption.TopDirectoryOnly));
                }

                updateImgListBox();
                if (imageLB.Items.Count > 0)
                {
                    imageLB.SelectedIndex = 0;
                }
            }
            catch (NullReferenceException nre)
            {
            }
            
        }

        private void imageLB_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                selected_img = CvInvoke.Imread(imageLB.SelectedItem.ToString());

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
                    project_directory_list.Remove(selected_directory);
                    updateFolderListBox();
                    imageLB.Items.Clear();
                   
                    mainPB.Image = null;
                    mainPB.Refresh();
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
                outputDirectoryTB.Text = openDir.SelectedPath;
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

        private void mainPB_MouseUp(object sender, MouseEventArgs e)
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
            FeatureLabel fl = new FeatureLabel(0, x, y, width, height);
            currentImgAnnotationsLB.Items.Add(fl.ToString());
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
                pen.Dispose();
            }
            else if (annotation_selected)
            {
                Rectangle rect = new Rectangle(current_annotation.X, current_annotation.Y, current_annotation.Width, current_annotation.Height);

                Graphics g = e.Graphics;
                Pen pen = new Pen(Color.Red, 2);
                g.DrawRectangle(pen, rect);

                
                // Create font and brush.
                Font drawFont = new Font("Arial", 16);
                SolidBrush drawBrush = new SolidBrush(Color.Red);
                // Set format of string.
                StringFormat drawFormat = new StringFormat();
                drawFormat.FormatFlags = StringFormatFlags.DirectionRightToLeft;

                g.DrawString(current_annotation.Id.ToString(), drawFont, drawBrush, current_annotation.X + 20, current_annotation.Y + 5, drawFormat);
                pen.Dispose();
                annotation_selected = false;
            }
        }

        /***********************************Image Remove Button********************************************/
        private void imgRemoveBTN_Click(object sender, EventArgs e)
        {
            try
            {
                imageLB.Items.Remove(imageLB.SelectedItem);
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

            current_annotation = FeatureLabel.FromString(currentImgAnnotationsLB.Text);

            annotation_selected = true;
            mainPB.Invalidate();
        }

        //***********************************A callback when delete annotation button is clicked/***********************************/
        private void deleteAnnotationBTN_Click(object sender, EventArgs e)
        {
            try
            {
                currentImgAnnotationsLB.Items.Remove(currentImgAnnotationsLB.SelectedItem);
                currentImgAnnotationsLB.SelectedIndex = 0;
            }
            catch (Exception ex)
            { 
            }
        }
    }
}
