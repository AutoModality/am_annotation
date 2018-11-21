using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Emgu.CV;
using System.Drawing;
using Emgu.CV.Structure;

namespace AM_Annotator
{
    class AnnotationImage
    {
        private string img_location;
        private bool ErrorInReading;
        private List<FeatureLabel> labels = new List<FeatureLabel>();

        public AnnotationImage()
        {
        }
        public AnnotationImage(string file_location)
        {
            img_location = file_location;
            try
            {
                var Image = CvInvoke.Imread(img_location);
            }
            catch (Exception e)
            {
                ErrorInReading = true;
            }
        }

        public bool isValid()
        {
            return ErrorInReading;
        }
        public bool isEmpty()
        {
            var Image = CvInvoke.Imread(img_location);
            return Image.IsEmpty;
        }
        public Mat getMat()
        {
            return CvInvoke.Imread(img_location);
        }
        public Image getImage()
        {
            Image<Bgr, Byte> my_image = CvInvoke.Imread(img_location).ToImage<Bgr, byte>();
            return my_image.ToBitmap();
        }
        public string getImageLocation()
        {
            return img_location;
        }
        public void addLabel(FeatureLabel fl)
        {
            labels.Add(fl);
        }
        public void addLabel(int id, int x, int y, int width, int height)
        {
            labels.Add(new FeatureLabel(id, x, y, width, height));
        }
        public void RemoveLabelAt(int index)
        {
            labels.RemoveAt(index);
        }
        public FeatureLabel getLabelAt(int index) 
        {
            if (index < 0 || index > labels.Count)
            {
                return new FeatureLabel();
            }

            return labels[index];
        }
        public List<FeatureLabel> getLabels()
        {
            return labels;
        }
        public List<string> getLabelsString()
        {
            List<string> annotations_str = new List<string>();
            foreach(FeatureLabel label in labels)
            {
                annotations_str.Add(label.ToString());
            }
            return annotations_str;
        }
       
    }
}
