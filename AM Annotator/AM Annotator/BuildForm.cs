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

namespace AM_Annotator
{
    public enum BUILD_LEVEL
    {
        BUILD_ALL,
        BUILD_OPENCV_ONLY,
        BUILD_DARKNET_ONLY,
        BUILD_VOC_ONLY
    };
    public partial class BuildForm : Form
    {
        private string opencv_output_location = "";
        private string darknet_output_location = "";
        private string pascal_output_location = "";


        public string OpencvOutputLocation { get { return opencv_output_location; } }
        public string DarknetOutputLocation { get { return darknet_output_location; } }
        public string PascalOutputLocation { get { return pascal_output_location; } }

        private Thread buildingThread;
        private List<AnnotationImage> annotations;
        private BUILD_LEVEL build_level;
        private OpencvAnnotationFormat oaf;
        private DarknetAnnotationFormat daf;
        private PascalVOCAnnotationFormat paf;

        public BuildForm(List<AnnotationImage> ai, BUILD_LEVEL build_lvl)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(Screen.PrimaryScreen.Bounds.Width / 2, Screen.PrimaryScreen.Bounds.Height / 2);
            annotations = ai;
            build_level = build_lvl;

        }
        private void BuildForm_Load(object sender, EventArgs e)
        {
            this.BringToFront();
            this.TopMost = true;

            //Depending on the build level, set the thread
            switch (build_level)
            {
                case BUILD_LEVEL.BUILD_ALL:
                    buildingThread = new Thread(new ThreadStart(BuildAll));
                    buildingThread.Start();
                    break;
                case BUILD_LEVEL.BUILD_OPENCV_ONLY:
                    buildingThread = new Thread(new ThreadStart(BuildOpenCV));
                    buildingThread.Start();
                    break;
                case BUILD_LEVEL.BUILD_DARKNET_ONLY:
                    buildingThread = new Thread(new ThreadStart(BuildDarknet));
                    buildingThread.Start();
                    break;
                case BUILD_LEVEL.BUILD_VOC_ONLY:
                    buildingThread = new Thread(new ThreadStart(BuildVOC));
                    buildingThread.Start();
                    break;
            }
            
        }

        /// <summary>
        /// Build OpenCV
        /// </summary>
        private void BuildOpenCV()
        {
            oaf = new OpencvAnnotationFormat(Properties.Settings.Default.ProjectLocation);
            for (int i = 0; i < annotations.Count; i++)
            {
                oaf.Add(annotations[i]);
                UpdateProgressBar(i / annotations.Count);
            }
            
            CloseForm();
        }
        /// <summary>
        /// Build OpenCV
        /// </summary>
        private void BuildDarknet()
        {
            daf = new DarknetAnnotationFormat(Properties.Settings.Default.ProjectLocation);
            for (int i = 0; i < annotations.Count; i++)
            {
                daf.Add(annotations[i]);
                UpdateProgressBar(i / annotations.Count);
            }
            CloseForm();
        }
        /// <summary>
        /// Build OpenCV
        /// </summary>
        private void BuildVOC()
        {
            paf = new PascalVOCAnnotationFormat(Properties.Settings.Default.ProjectLocation);
            for (int i = 0; i < annotations.Count; i++)
            {
                paf.Add(annotations[i]);
                UpdateProgressBar(i / annotations.Count);
            }
            CloseForm();
        }
        /// <summary>
        /// Build All
        /// </summary>
        private void BuildAll()
        {
            oaf = new OpencvAnnotationFormat(Properties.Settings.Default.ProjectLocation);
            daf = new DarknetAnnotationFormat(Properties.Settings.Default.ProjectLocation);
            paf = new PascalVOCAnnotationFormat(Properties.Settings.Default.ProjectLocation);
            for (int i = 0; i < annotations.Count; i++)
            {
                paf.Add(annotations[i]);
                oaf.Add(annotations[i]);
                daf.Add(annotations[i]);
                UpdateProgressBar((double)i * 100.0 / (double)annotations.Count);
                //Thread.Sleep(1);
            }

            daf.CreateTrainCollection(Properties.Settings.Default.TrainPercentage);
            paf.CreateTrainCollection(Properties.Settings.Default.TrainPercentage);
            UpdateProgressBar(100.0);
            CloseForm();
        }

        /// <summary>
        /// Thread Safe Updating the building progressbar
        /// </summary>
        /// <param name="value">increment Value</param>
        private void UpdateProgressBar(double value)
        {
            this.Invoke((MethodInvoker)delegate
            {
                buildingProgressBar.Value = (int)value;
            });
        }
        /// <summary>
        /// Thread Safe Form Close
        /// </summary>
        private void CloseForm()
        {
            this.Invoke((MethodInvoker)delegate
            {
                this.Close();
            }
            );
        }
        
        /*Dummy function for debugging*/
        private void dummyIncrement()
        {
            while (buildingProgressBar.Value + 10  <= buildingProgressBar.Maximum)
            {
                this.Invoke((MethodInvoker)delegate
               {
                   buildingProgressBar.Value += 10;
               });
                Thread.Sleep(1000);
            }

            this.Invoke((MethodInvoker)delegate
           {

               this.Close();
           });
        }

    }
}
