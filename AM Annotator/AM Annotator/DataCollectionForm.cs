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
    }
}
