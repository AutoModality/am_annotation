using System;
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

        public PascalVOCAnnotationFormat()
        {
        }

        public PascalVOCAnnotationFormat(string output_directory)
        {
            output_directory_raw = output_directory + "\\pascalvoc_annoations";
            Directory.CreateDirectory(output_directory_raw);
        }

        public void Add(AnnotationImage ai)
        {
            List<FeatureLabel> labels = ai.GetLabels();
            if (labels.Count == 0)
            {
                return;
            }

            //Set the path to the file
            string folder_path = output_directory_raw + "\\" + ai.GetParentFolder();
            Directory.CreateDirectory(folder_path);

            string annotation_path = folder_path + "\\" + Path.GetFileNameWithoutExtension(ai.GetFileName()) + ".xml";

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
            writer.WriteElementString("filename", ai.GetFileName());
            writer.WriteElementString("path", ai.GetImageLocation());

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
                writer.WriteElementString("name", Convert.ToString(label.Id));
                writer.WriteElementString("pose", Convert.ToString("Frontal"));
                writer.WriteElementString("truncated", Convert.ToString(0));
                writer.WriteElementString("difficult", Convert.ToString(0));
                writer.WriteElementString("occluded", Convert.ToString(0));

                writer.WriteStartElement("bndbox");
                writer.WriteElementString("xmin", Convert.ToString(label.X));
                writer.WriteElementString("xmax", Convert.ToString(label.End_X));
                writer.WriteElementString("ymin", Convert.ToString(label.Y));
                writer.WriteElementString("ymax", Convert.ToString(label.End_Y));
                writer.WriteEndElement();

            }
            writer.WriteEndElement();

            writer.WriteEndElement();
            writer.WriteEndDocument();
            writer.Close();
        }
    }
}
