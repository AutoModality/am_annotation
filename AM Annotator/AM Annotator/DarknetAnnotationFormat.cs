using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Darknet Annotation:
 * The annotation file name is taken from image file name
 * All annotations whose images are in one directory will be placed in the one directory.
 * The training software selects the training images and annotations
 * It is recommended to put all images in one directory
 */

namespace AM_Annotator
{
    class DarknetAnnotationFormat
    {
        private string darknet_path = "";
        private string alias_directory = "";
        private List<AnnotationImage> annotation_images = new List<AnnotationImage>();

        //Constructor
        public DarknetAnnotationFormat(string project_path, string alias_dir = "")
        {
            darknet_path = project_path + "\\darknet_annotations";
            alias_directory = alias_dir;
            try
            {
                Directory.CreateDirectory(darknet_path);
            }
            catch (Exception ex)
            {

            }            
        }


        public DarknetAnnotationFormat()
        {
        }

        //A public method to add annotations
        public void Add(AnnotationImage ai)
        {
            //We only add the ones with nonzero labels
            if (ai.GetLabels().Count == 0)
            {
                return;
            }
            //Find the location that this annotation needs to go
            //string annotation_path = darknet_path + "\\" + ai.GetParentFolder();
            //Directory.CreateDirectory(annotation_path);

            //Find the annotation file name and path
            string annotation_file_location = darknet_path + "\\img_" + ai.GetGlobalIndex().ToString() + ".txt";

            //write each relative label and save it into the txt file
            File.WriteAllLines(annotation_file_location, ai.GetRelativesString().ToArray());
            annotation_images.Add(ai);
        }

        //A public method to create train and test images
        public void CreateTrainCollection(double train_percentage)
        {
            //Setting the train and test file location
            string test_file_location = darknet_path + "\\test.txt";
            string train_file_location = darknet_path + "\\train.txt";

            try
            {
                File.Delete(test_file_location);
                File.Delete(train_file_location);
            }
            catch (Exception ex)
            {
            }
            

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

        //A public method to remove the entire annotation
        public void Remove(AnnotationImage ai)
        {

        }

        //A public method to remove a label from an annotation
        public void Remove(AnnotationImage ai, FeatureLabel fl)
        {
        }
    }
}
