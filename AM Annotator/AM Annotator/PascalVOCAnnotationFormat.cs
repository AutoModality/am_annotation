﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace AM_Annotator
{
    class PascalVOCAnnotationFormat
    {
        private string output_directory_raw;
        private string output_directory_;
        private List<AnnotationImage> annotation_images = new List<AnnotationImage>();
        private string alias_directory = "";
        Dictionary<int, string> class_names_ = new Dictionary<int, string>();
        public PascalVOCAnnotationFormat()
        {
        }

        public PascalVOCAnnotationFormat(string output_directory, Dictionary<int, string> class_names,string alias_dir = "")
        {
            output_directory_ = output_directory;
            class_names_ = class_names;
            output_directory_raw = output_directory + "\\pascalvoc_annotations";
            alias_directory = alias_dir;
            Directory.CreateDirectory(output_directory_raw);
        }

        //A public method to create train and test images
        public void CreateTrainCollection(double train_percentage)
        {
            //Setting the train and test file location
            string test_file_location = output_directory_raw + "\\test.txt";
            string train_file_location = output_directory_raw + "\\train.txt";

            List<string> trainList = new List<string>();
            int nTrainingImgs = (int)(annotation_images.Count * train_percentage * 0.01);
            Random random = new Random();
            //Iterating through the train list
            while (trainList.Count < nTrainingImgs)
            {

                int index = random.Next(0, annotation_images.Count - 1);
                if (!trainList.Contains(annotation_images[index].GetImageLocation()))
                {
                    trainList.Add(annotation_images[index].GetImageLocation());
                    //Write it to the train file
                    using (System.IO.StreamWriter sw = new System.IO.StreamWriter(train_file_location, true))
                    {
                        sw.WriteLine(annotation_images[index].GetImageLocation());
                        sw.Close();
                    }
                }
            }
            //Setting up the train 
            foreach (AnnotationImage ai in annotation_images)
            {
                if (!trainList.Contains(ai.GetImageLocation()))
                {
                    //Write it to the train file
                    using (System.IO.StreamWriter sw = new System.IO.StreamWriter(test_file_location, true))
                    {
                        sw.WriteLine(ai.GetImageLocation());
                        sw.Close();
                    }
                }
            }
        }

        public void Add(AnnotationImage ai)
        {
            List<FeatureLabel> labels = ai.GetLabels();
            if (labels.Count == 0)
            {
                return;
            }

            annotation_images.Add(ai);

            //Set the path to the file
            //string folder_path = output_directory_raw + "\\" + ai.GetParentFolder();
            //Directory.CreateDirectory(folder_path);
            //ai.SetImageLocation(output_directory_ + "\\images\\img_"+ ai.GetGlobalIndex().ToString() + Path.GetExtension(ai.GetFileName()).ToString());
            string new_image_name = "img_" + ai.GetGlobalIndex().ToString() + Path.GetExtension(ai.GetFileName()).ToString();
            string annotation_path = output_directory_raw + "\\img_" + ai.GetGlobalIndex().ToString() + ".xml";
            

            //Setting up the xml writer setting
            XmlWriterSettings xws = new XmlWriterSettings();
            xws.NewLineHandling = NewLineHandling.Replace;
            xws.NewLineChars = Environment.NewLine;
            xws.IndentChars = ("\t");
            xws.Indent = true;
            xws.ConformanceLevel = ConformanceLevel.Auto;
            xws.OmitXmlDeclaration = true;

            XmlWriter writer = XmlWriter.Create(annotation_path, xws);
            writer.WriteStartDocument();
            writer.WriteStartElement("annotation");

            writer.WriteElementString("folder", ai.GetParentFolder());
            //writer.WriteElementString("filename", ai.GetFileName());
            writer.WriteElementString("filename", new_image_name);
            //writer.WriteElementString("path", ai.GetImageLocation());

            writer.WriteStartElement("source");
            writer.WriteElementString("database", "Unknown");
            writer.WriteEndElement();

            writer.WriteStartElement("size");
            writer.WriteElementString("width", Convert.ToString(ai.GetWidth()));
            writer.WriteElementString("height", Convert.ToString(ai.GetHeight()));
            writer.WriteElementString("depth", Convert.ToString(ai.GetNumOfChannels()));
            writer.WriteEndElement();

            writer.WriteElementString("segmented", Convert.ToString(0));

            writer.WriteStartElement("object");
            foreach (FeatureLabel label in labels)
            {
                writer.WriteElementString("name", getClassName(label.Id));
                writer.WriteElementString("pose", Convert.ToString("Frontal"));
                writer.WriteElementString("truncated", Convert.ToString(0));
                writer.WriteElementString("difficult", Convert.ToString(0));
                writer.WriteElementString("occluded", Convert.ToString(0));

                writer.WriteStartElement("bndbox");
                writer.WriteElementString("xmin", Convert.ToString(label.X));
                writer.WriteElementString("ymin", Convert.ToString(label.Y));
                writer.WriteElementString("xmax", Convert.ToString(label.End_X));
                writer.WriteElementString("ymax", Convert.ToString(label.End_Y));
                writer.WriteElementString("width", Convert.ToString(label.Width));
                writer.WriteElementString("height", Convert.ToString(label.Height));
                writer.WriteElementString("xcenter", Convert.ToString(label.X + label.Width/2));
                writer.WriteElementString("ycenter", Convert.ToString(label.Y + label.Height/2));
                writer.WriteEndElement();

            }
            writer.WriteEndElement();

            writer.WriteEndElement();
            writer.WriteEndDocument();
            writer.Close();
        }

        private string getClassName(int id)
        {
            return class_names_[id];
        }


    }
}
