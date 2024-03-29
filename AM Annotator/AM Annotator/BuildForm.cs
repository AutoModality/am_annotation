﻿using System;
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
        private Thread imageCopyThread;
        private List<AnnotationImage> annotations, tmp_annotations;
        private BUILD_LEVEL build_level;
        private OpencvAnnotationFormat oaf;
        private DarknetAnnotationFormat daf;
        private PascalVOCAnnotationFormat paf;
        private Dictionary<int, string> class_names;

        //This method, copies the training images to a unique directory and renamed them with the global index
        private void OrganizeImages()
        {
            //create the Image directory in the output directory
            String image_directory = Properties.Settings.Default.ProjectLocation + "\\images";
            Directory.CreateDirectory(image_directory);

            foreach (AnnotationImage ai in annotations)
            {
                if (ai.GetLabels().Count <= 0)
                {
                    continue;
                }
                String destination_path = image_directory + "\\img_" + ai.GetGlobalIndex().ToString() + Path.GetExtension(ai.GetFileName());
                try
                {
                    File.Copy(ai.GetImageLocation(), destination_path);
                }
                catch (IOException ioe)
                {
                }
            }
        }

        public BuildForm(List<AnnotationImage> ais, Dictionary<int, string> class_names, BUILD_LEVEL build_lvl)
        {
            InitializeComponent();
            this.class_names = class_names;
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(Screen.PrimaryScreen.Bounds.Width / 2, Screen.PrimaryScreen.Bounds.Height / 2);
            annotations = new List<AnnotationImage>();
            tmp_annotations = new List<AnnotationImage>();

            int idx = 0;
            foreach (AnnotationImage ai in ais)
            {
                AnnotationImage tmp = ai;
                annotations.Insert(idx,tmp);
                tmp_annotations.Insert(idx, tmp);
                idx++;
            }
            build_level = build_lvl;

        }
        private void BuildForm_Load(object sender, EventArgs e)
        {
            this.BringToFront();
            this.TopMost = true;

            ///Organize the images
            imageCopyThread = new Thread(new ThreadStart(OrganizeImages));
            imageCopyThread.Start();
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
            paf = new PascalVOCAnnotationFormat(Properties.Settings.Default.ProjectLocation, this.class_names);
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
            paf = new PascalVOCAnnotationFormat(Properties.Settings.Default.ProjectLocation, this.class_names);
            PrintInTerminal("Start Building All...");
            for (int i = 0; i < annotations.Count; i++)
            {
                paf.Add(annotations[i]);
                oaf.Add(annotations[i]);
                daf.Add(annotations[i]);
                UpdateProgressBar((double)i * 100.0 / (double)annotations.Count);
                //Thread.Sleep(1);
            }

            PrintInTerminal("Done");
            //daf.CreateTrainCollection(Properties.Settings.Default.TrainPercentage);
            //paf.CreateTrainCollection(Properties.Settings.Default.TrainPercentage);
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

        /*********************************************Thread Safe Terminal Print*************************************************/
        private void PrintInTerminal(string msg)
        {
            this.Invoke((MethodInvoker) delegate
            {
                terminal.AppendText(msg);
            });
        }

        private void buildingProgressBar_Click(object sender, EventArgs e)
        {

        }
    }
}
