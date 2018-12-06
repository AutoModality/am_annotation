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
        private int img_width;
        private int img_height;
        private int img_channel;
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
                img_width = Image.Width;
                img_height = Image.Height;
                img_channel = Image.NumberOfChannels;
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
            if (fl.X < 0) fl.X = 0;
            if (fl.Y < 0) fl.Y = 0;
            if (fl.Width < 0) fl.Width = 0;
            if (fl.Height < 0) fl.Height = 0;

            if (!labels.Contains(fl) && fl.Width !=0 && fl.Height != 0)
            {
                labels.Add(fl);
            }
            
        }
        public void AddLabel(int id, int x, int y, int width, int height)
        {
            if (x < 0) x = 0;
            if (y < 0) y = 0;
            if (width < 0) width = 0;
            if (height < 0) height = 0;

            if (x + width > img_width) width = img_width - x;
            if (y + height > img_width) height = img_height - y;
            //if (!labels.Contains(new FeatureLabel(id, x, y, width, height)) && width != 0 && height != 0)
            if (!labels.Any(fl => fl.X == x && fl.Y == y && fl.Width == width && fl.Height == height) && width != 0 && height != 0)
            {
                labels.Add(new FeatureLabel(id, x, y, width, height));
            }
            
        }
        public void RemoveLabelAt(int index)
        {
            labels.RemoveAt(index);
        }
        public void RemoveAllLabels()
        {
            labels.Clear();
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
                FeatureLabel fl = new FeatureLabel(label.Id, Convert.ToInt32(label.X / img_width), Convert.ToInt32(label.Y / img_height), Convert.ToInt32(label.Width / img_width), Convert.ToInt32(label.Height/ img_height));
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
                annotation_str.Add(label.Id.ToString() + " " + ((double)label.X / (double)img_width).ToString() + " " + ((double)label.Y / (double)img_height).ToString()
                    + " " + ((double)label.Width / (double)img_width).ToString() + " " + ((double)label.Height / (double)img_height));
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
            return img_width;
        }
        public int GetHeight()
        {
            return img_height;
        }
        public int GetNumOfChannels()
        {
            return img_channel;
        }
       
        
    }
}
