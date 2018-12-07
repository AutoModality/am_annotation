using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.IO;

namespace AM_Annotator
{
    public partial class ProjectOrganizerForm : Form
    {
       
        private double train_percentage = 90;
        private int nAnnotationFiles = 0;
        private string annotation_output_path = "";
        private string image_output_path = "";
        Thread run;

        public ProjectOrganizerForm()
        {
            InitializeComponent();
        }

        private void ProjectOrganizerForm_Load(object sender, EventArgs e)
        {
            projectOrganizerToolStripMenuItem.Enabled = false;


            try
            {
                //loading the settings
                foreach (string annotationFolder in Properties.Settings.Default.AnntationFolders)
                {
                    if (annotationFolder == "Empty") continue;
                    annotationFolderLB.Items.Add(annotationFolder);
                }
                foreach (string imgFolder in Properties.Settings.Default.ImageFolders)
                {
                    if (imgFolder == "Empty") continue;
                    imgFolderLB.Items.Add(imgFolder);
                }
                outputDirectoryTB.Text = Properties.Settings.Default.OutputDirectory;
                train_percentage = Properties.Settings.Default.OrganizerTrainPercentage;
                trainPercentageNUD.Value = Convert.ToDecimal(train_percentage);
            }
            catch (Exception NRE)
            {
                printInTerminal("Error in reading the settings.");
            }
            
        }

        //Thread safe method to write into the terminal
        private void printInTerminal(string msg)
        {
            this.Invoke((MethodInvoker)delegate
            {
                terminal.AppendText(msg + "\n");
            });
        }

        //When Run button is pressed
        private void runBTN_Click(object sender, EventArgs e)
        {
            string error_msg = "Please fix the following(s): \n";
            bool thereIsError = false;
            
            if (outputDirectoryTB.Text == "")
            {
                error_msg += "Set a valid output directory for images\n";
                thereIsError = true;
            }
            if (imgFolderLB.Items.Count == 0)
            {
                error_msg += "No source image folder\n";
                thereIsError = true;
            }
            if (annotationFolderLB.Items.Count == 0)
            {
                error_msg += "No source annotation folder\n";
                thereIsError = true;
            }
            if (imgFolderLB.Items.Count != annotationFolderLB.Items.Count)
            {
                error_msg += "No source image folder\n";
                thereIsError = true;
            }
            if (thereIsError)
            {
                MessageBox.Show(error_msg, "Run Failed");
                return;
            }

            //If there is no error
            run = new Thread(organize);
            run.IsBackground = true;
            run.Start();
        }

        //Setting the image output directory
        private void imgOutputSetBTN_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog openDir = new FolderBrowserDialog();
            if (openDir.ShowDialog() == DialogResult.OK)
            {
                outputDirectoryTB.Text = openDir.SelectedPath;
            }
        }
        

        //Adding image folders
        private void addImgFolderBTN_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog openDir = new FolderBrowserDialog();
            if (openDir.ShowDialog() == DialogResult.OK && !imgFolderLB.Items.Contains(openDir.SelectedPath))
            {
                imgFolderLB.Items.Add(openDir.SelectedPath);
            }
        }
        //Removing image folders 
        private void removeImgFolderBTN_Click(object sender, EventArgs e)
        {
            if (imgFolderLB.SelectedIndex >= 0 && imgFolderLB.SelectedIndex < imgFolderLB.Items.Count && imgFolderLB.Items.Count > 0)
            {
                imgFolderLB.Items.RemoveAt(imgFolderLB.SelectedIndex);
            }
        }

        //Adding annotation folders
        private void addAnnotationFolderBTN_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog openDir = new FolderBrowserDialog();
            if (openDir.ShowDialog() == DialogResult.OK && !annotationFolderLB.Items.Contains(openDir.SelectedPath))
            {
                annotationFolderLB.Items.Add(openDir.SelectedPath);
            }
        }
        //Removing annotation folders 
        private void removeAnnotationFolderBTN_Click(object sender, EventArgs e)
        {
            if (annotationFolderLB.SelectedIndex >= 0 && annotationFolderLB.SelectedIndex < annotationFolderLB.Items.Count && annotationFolderLB.Items.Count > 0)
            {
                annotationFolderLB.Items.RemoveAt(annotationFolderLB.SelectedIndex);
            }
        }

        //Thread safe gui control
        private void GUIAccess(bool access)
        {
            this.Invoke((MethodInvoker)delegate
            {
                addAnnotationFolderBTN.Enabled = access;
                addImgFolderBTN.Enabled = access;
                removeAnnotationFolderBTN.Enabled = access;
                removeImgFolderBTN.Enabled = access;
                runBTN.Enabled = access;
                imgOutputSetBTN.Enabled = access;
            });
        }

        //Update Progress bar thread safe
        private void IncrementProgressBar(int value)
        {
            this.Invoke((MethodInvoker) delegate
            {
                executionPB.Value += value;
            });
        }

        //Set Maximum to Progress Bar
        private void SetMaximumProgressBar(int value)
        {
            this.Invoke((MethodInvoker)delegate
            {
                executionPB.Maximum = value;
            });
        }
        /************************************************Organization Process************************************************/
        private void organize()
        {
            annotation_output_path = outputDirectoryTB.Text + "\\labels";
            image_output_path = outputDirectoryTB.Text + "\\images";
            Directory.CreateDirectory(annotation_output_path);
            Directory.CreateDirectory(image_output_path);


            nAnnotationFiles = 0;
            int currentFileCnt = -1;
            //Disabling the gui
            GUIAccess(false);
            printInTerminal("Processing ...");
            //Count the total number of annotations. That is how long it will take
            for (int i = 0; i < annotationFolderLB.Items.Count; i++)
            {
                DirectoryInfo d = new DirectoryInfo(Convert.ToString(annotationFolderLB.Items[i]));//Assuming Test is your Folder
                FileInfo[] Files = d.GetFiles("*.txt"); //Getting Text files
                nAnnotationFiles += Files.Count();
            }
            printInTerminal("Processing ... Done. Total Number of Images: " + nAnnotationFiles.ToString());
            //Update Progressbar maximum Value
            SetMaximumProgressBar(nAnnotationFiles);

            //Start the Process
            for (int i = 0; i < annotationFolderLB.Items.Count; i++)
            {
                DirectoryInfo d = new DirectoryInfo(Convert.ToString(annotationFolderLB.Items[i]));//Assuming Test is your Folder
                FileInfo[] Files = d.GetFiles("*.txt"); //Getting Text files
                //For each annotation file in the annotation folder
                foreach (FileInfo f in Files)
                {
                    currentFileCnt++;
                    //find the stem name without the .txt extension
                    string file_name_no_extension = Path.GetFileNameWithoutExtension(f.FullName);
                    //Also, get the parent folder name. In theory, both images and annotation should have the same immediate parent name
                    //string parent_name = new DirectoryInfo(f.FullName).Parent;
                    //string parent_name = Convert.ToString(Directory.Get(f.FullName).ToString());
                    string parent_name = Path.GetFileName(Path.GetDirectoryName(f.FullName));

                    //select the image folder that contains the parent + file_name_no_extension + either png/jpg (image extension is a hack)
                    string image_path = "";
                    foreach (string image_folder in imgFolderLB.Items)
                    {
                        if (image_folder.Contains(parent_name))
                        {
                            image_path = image_folder;
                        }
                    }
                    image_path +=  "\\" + file_name_no_extension;

                    string img_extension = "";
                    if (File.Exists(image_path + ".png"))
                    {
                        image_path += ".png";
                        img_extension = ".png";
                    }
                    else if (File.Exists(image_path + ".jpg"))
                    {
                        image_path += ".jpg";
                        img_extension = ".jpg";
                    }

                    //Now that you have them both, copy them to new locations renamed.
                    string newStemName = "img-" + currentFileCnt.ToString().PadLeft(Convert.ToInt32(Math.Floor(Math.Log10(nAnnotationFiles) + 1)), '0');
                    //copy to the new image path
                    File.Copy(image_path, image_output_path + "\\" + newStemName + img_extension);
                    //copy to the new annotation path
                    File.Copy(f.FullName, annotation_output_path + "\\" + newStemName + ".txt");
                    //Done with organizing this image

                    //increment progress bar
                    IncrementProgressBar(1);
                    printInTerminal("Done Processing: " + image_path);
                }
            }

            //Collection test and train data
            //CreateTrainCollection();

            //re-enable the gui
            GUIAccess(true);
            printInTerminal("Done.");
        }

        /************************************************Saving the Settings************************************************/
        private void saveSettingBTN_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.AnntationFolders = new System.Collections.Specialized.StringCollection();
            Properties.Settings.Default.ImageFolders = new System.Collections.Specialized.StringCollection();
            foreach (string annotationFolder in annotationFolderLB.Items)
            {
                Properties.Settings.Default.AnntationFolders.Add(annotationFolder);
            }
            foreach (string imgFolder in imgFolderLB.Items)
            {
                Properties.Settings.Default.ImageFolders.Add(imgFolder);
            }
            Properties.Settings.Default.OutputDirectory = outputDirectoryTB.Text;
            Properties.Settings.Default.OrganizerTrainPercentage = train_percentage;

            Properties.Settings.Default.Save();
        }

        /************************************************Creating train and test collection**********************************************************/
        private void CreateTrainCollection()
        {
            printInTerminal("Creating Train and Test Collection.");
            

            //Setting the train and test file location
            string test_file_location = outputDirectoryTB.Text + "\\test.txt";
            string train_file_location = outputDirectoryTB.Text + "\\train.txt";

            //Delete the files if any
            try
            {
                File.Delete(test_file_location);
                File.Delete(train_file_location);
            }
            catch (Exception ex)
            {
            }

           
            DirectoryInfo d = new DirectoryInfo(Convert.ToString(image_output_path));//Assuming Test is your Folder
            List<FileInfo> images = new List<FileInfo>();
            //FileInfo[] Files = d.GetFiles("*.png"); //Getting Text files
            images.AddRange(d.GetFiles("*.png"));
            images.AddRange(d.GetFiles("*.jpg"));
            printInTerminal("Done collecting the images");

            List<string> trainList = new List<string>();
            int nTrainingImgs = (int)(images.Count * train_percentage * 0.01);
            Random random = new Random();
            //Iterating through the train list
            while (trainList.Count < nTrainingImgs)
            {
                int index = random.Next(0, images.Count - 1);
                if (!trainList.Contains(images[index].FullName))
                {
                    trainList.Add(images[index].FullName);
                    //Write it to the train file
                    using (System.IO.StreamWriter sw = new System.IO.StreamWriter(train_file_location, true))
                    {

                        sw.WriteLine(images[index].FullName);
                        sw.Close();
                        //increment progress bar
                        IncrementProgressBar(1);
                    }
                }
            }
            //Setting up the train 
            foreach (FileInfo image in images)
            {
                if (!trainList.Contains(image.FullName))
                {
                    //Write it to the train file
                    using (System.IO.StreamWriter sw = new System.IO.StreamWriter(test_file_location, true))
                    {
                        sw.WriteLine(image.FullName);
                        sw.Close();
                        //increment progress bar
                        IncrementProgressBar(1);
                    }
                }
            }
            printInTerminal("Train and Test Collection is Done.");
        }

        private void trainPercentageNUD_ValueChanged(object sender, EventArgs e)
        {
            train_percentage = Convert.ToDouble(trainPercentageNUD.Value);
        }
    }
}
