using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Emgu.CV;
using System.Drawing;
using Emgu.CV.Structure;
using System.IO;

namespace AM_Annotator
{
    public class AnnotationImage
    {
        private string img_location;
        private bool ErrorInReading;
        private int width;
        private int height;
        private int channel;
        private List<FeatureLabel> labels = new List<FeatureLabel>();
        
        //Constructors
        public AnnotationImage()
        {
        }
        public AnnotationImage(string file_location)
        {
            img_location = file_location;
            try
            {
                var Image = CvInvoke.Imread(img_location);
                width = Image.Width;
                height = Image.Height;
                channel = Image.NumberOfChannels;
            }
            catch (Exception e)
            {
                ErrorInReading = true;
            }
        }
        

        public bool IsValid()
        {
            return ErrorInReading;
        }
        public bool IsEmpty()
        {
            var Image = CvInvoke.Imread(img_location);
            return Image.IsEmpty;
        }
        public Mat GetMat()
        {
            return CvInvoke.Imread(img_location);
        }
        public Image GetImage()
        {
            Image<Bgr, Byte> my_image = CvInvoke.Imread(img_location).ToImage<Bgr, byte>();
            return my_image.ToBitmap();
        }
        public string GetImageLocation()
        {
            return img_location;
        }
        public void AddLabel(FeatureLabel fl)
        {
            labels.Add(fl);
        }
        public void AddLabel(int id, int x, int y, int width, int height)
        {
            labels.Add(new FeatureLabel(id, x, y, width, height));
        }
        public void RemoveLabelAt(int index)
        {
            labels.RemoveAt(index);
        }

        //Getting all the labels Absolute and Relative
        public FeatureLabel GetLabelAt(int index) 
        {
            if (index < 0 || index > labels.Count)
            {
                return new FeatureLabel();
            }

            return labels[index];
        }
        //Getting all Absolute Labels
        public List<FeatureLabel> GetLabels()
        {
            return labels;
        }

        //Getting All Relative Labels
        public List<FeatureLabel> GetRelativeLabels()
        {
            List<FeatureLabel> relative_labels = new List<FeatureLabel>();

            foreach (FeatureLabel label in labels)
            {
                FeatureLabel fl = new FeatureLabel(label.Id, Convert.ToInt32(label.X / width), Convert.ToInt32(label.Y / height), Convert.ToInt32(label.Width / width), Convert.ToInt32(label.Height/ height));
                relative_labels.Add(fl);
            }

            return relative_labels;
        }

        //Getting absolute labels in string format
        public List<string> GetAbsoluteString()
        {
            List<string> annotations_str = new List<string>();
            foreach(FeatureLabel label in labels)
            {
                annotations_str.Add(label.ToString());
            }
            return annotations_str;
        }

        //Getting relative labels in string format
        public List<string> GetRelativesString()
        {
            List<string> annotation_str = new List<string>();
            foreach (FeatureLabel label in labels)
            {
                annotation_str.Add(label.Id.ToString() + " " + ((double)label.X / (double)width).ToString() + " " + ((double)label.Y / (double)height).ToString()
                    + " " + ((double)label.Width / (double)width).ToString() + " " + ((double)label.Height / (double)height));
            }

            return annotation_str;
        }


        public string GetParentFolder()
        {
            return Convert.ToString(Directory.GetParent(img_location).Name);
            //return Path.GetPathRoot(img_location);
        }
        public string GetParentPath()
        {
            return Convert.ToString(Directory.GetParent(img_location).ToString());
        }
        public string GetFileName()
        {
            return Path.GetFileName(img_location);
        }
        public string GetStem()
        {
            return Path.GetFileNameWithoutExtension(img_location);
        }
        public int GetWidth()
        {
            return width;
        }
        public int GetHeight()
        {
            return height;
        }
        public int GetNumOfChannels()
        {
            return channel;
        }
       
    }
}
