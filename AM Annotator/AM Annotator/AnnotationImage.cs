using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Emgu.CV;

namespace AM_Annotator
{
    class AnnotationImage
    {
        private Mat img;
        private string img_location;
        private bool errorInReading = false;
        private List<FeatureLabel> labels = new List<FeatureLabel>();

        public AnnotationImage(string file_location)
        {
            img_location = file_location;
            try
            {
                img = CvInvoke.Imread(img_location);
            }
            catch (Exception e)
            {
                errorInReading = true;
            }
        }

        public bool isValidImage()
        {
            return errorInReading;
        }
        public bool isEmpty()
        {
            return img.IsEmpty;
        }
        public Mat getImage()
        {
            return img;
        }
        public string getLocation()
        {
            return img_location;
        }
        public void addLabel(int id, int x, int y, int width, int height)
        {
            var label = new FeatureLabel(id, x, y, width, height);
        }
        public List<FeatureLabel> getLabels()
        {
            return labels;
        }
    }
}
