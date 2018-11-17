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
        private List<string> project_directory_list = new List<string>();
        private List<string> supported_img_format = new List<string>{ "jpg", "jpeg", "png", "gif", "tiff", "bmp" };
        private List<string> current_directory_img_list = new List<string>();
        private string last_openned_directory = @"C:\";

        Mat selected_img = new Mat();
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
                imageLB.SelectedIndex = 0;
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
    }
}
