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
using Emgu.CV.Ocl;
using System.IO;
using System.Net;

namespace AM_Annotator
{
    public partial class DataCollectionForm : Form
    {
        System.Threading.Thread search_thread;

        public DataCollectionForm()
        {
            InitializeComponent();
        }

        private void DataCollectionForm_Load(object sender, EventArgs e)
        {
            dataCollectionToolStripMenuItem.Enabled = false;
            search_thread = new Thread(new System.Threading.ThreadStart(searchForDevices));
            search_thread.Start();
        }

        private void searchForDevices()
        {
            for (int i = 0; i < 10; i++)
            {
                
                try
                {
                    Emgu.CV.VideoCapture vc = new Emgu.CV.VideoCapture(i);
                    if (vc.IsOpened)
                    {

                    }
                }
                catch (Exception ex)
                {

                }

            }
            search_thread.Abort();
        }

        /***********************************Starting the Annotator App***********************************/
        private void StartAnnotator()
        {
            Application.Run(new mainWindow(false));
        }
        private void annotatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(StartAnnotator));
            t.SetApartmentState(System.Threading.ApartmentState.STA);
            t.Start();
            this.Close();
        }



        /***********************************Starting the Project Organizer App***********************************/
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

        private void searchBTN_Click(object sender, EventArgs e)
        {
            //Check for Errors
            string error_str = "";
            if (searchTB.Text == "")
            {
                error_str += "No search string. \n";
            }
            if (NetwrokIsDown())
            {
                error_str += "Network is down. Check your connnection.\n";
            }
            if (numberOfImagesNUD.Value <= 0)
            {
                error_str += "Number of images should be valid.\n";
            }
            if (outputImageTB.Text == "" || !Directory.Exists(outputImageTB.Text))
            {
                error_str += "Enter a valid path for outputw.\n";
            }
            if (error_str != "")
            {
                MessageBox.Show(error_str, "Failed to Search");
                return;
            }


            //Getting the images
            var urls = GetUrls(searchTB.Text);
            for (int img_cnt = 0; img_cnt < numberOfImagesNUD.Value; img_cnt++)
            {
                GetImage(urls[img_cnt]);
            }
        }

        /// <summary>
        /// A routine to see if the network is down
        /// </summary>
        /// <returns></returns>
        private bool NetwrokIsDown()
        {
            return System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable();
        }


        /// <summary>
        /// Getting all the urls from the given search keywords
        /// </summary>
        /// <param name="topic"></param>
        /// <returns></returns>
        private List<string> GetUrls(string topic)
        {
            List<string> urls = new List<string>();

            //setting up the search string
            topic.Replace(' ', '+');

            string url = "https://www.google.com/search?q=" + topic + "&tbm=isch";
            
            string htmlResponse = "";

            var request = (HttpWebRequest)WebRequest.Create(url);
            var response = (HttpWebResponse)request.GetResponse();
            //receiving the html response
            using (Stream dataStream = response.GetResponseStream())
            {
                if (dataStream == null)
                {
                    MessageBox.Show("Something went wrong", "Failed to obtain response");
                }
                using (var sr = new StreamReader(dataStream))
                {
                    htmlResponse = sr.ReadToEnd();
                }
            }


            //separating the urls
            int ndx = htmlResponse.IndexOf("\"ou\"", StringComparison.Ordinal);

            while (ndx >= 0)
            {
                ndx = htmlResponse.IndexOf("\"", ndx + 4, StringComparison.Ordinal);
                ndx++;
                int ndx2 = htmlResponse.IndexOf("\"", ndx, StringComparison.Ordinal);
                string img_url = htmlResponse.Substring(ndx, ndx2 - ndx);
                urls.Add(url);
                ndx = htmlResponse.IndexOf("\"ou\"", ndx2, StringComparison.Ordinal);
            }
            return urls;
        }

        /// <summary>
        /// Getting an image from the passed url
        /// </summary>
        /// <param name="url">url to the image</param>
        /// <returns></returns>
        private Image GetImage(string url)
        {
            Image result;
            var request = (HttpWebRequest)WebRequest.Create(url);
            var response = (HttpWebResponse)request.GetResponse();
            using (Stream dataStream = response.GetResponseStream())
            {
                if (dataStream == null)
                    return null;
                using (var sr = new BinaryReader(dataStream))
                {
                    byte[] bytes = sr.ReadBytes(100000);
                    using (var ms = new MemoryStream(bytes))
                    {
                        result = Image.FromStream(ms);
                    }
                }
            }
            return result;
        }
    }
}
