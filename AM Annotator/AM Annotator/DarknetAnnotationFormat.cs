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

        //Constructor
        public DarknetAnnotationFormat(string project_path)
        {
            darknet_path = project_path + "\\darknet_annotations";
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
            //Find the location that this annotation needs to go
            string annotation_path = darknet_path + "\\" + ai.GetParentFolder();
            Directory.CreateDirectory(annotation_path);

            //Find the annotation file name and path
            string annotation_file_location = annotation_path + "\\" + ai.GetFileName() + ".txt";

            //write each relative label and save it into the txt file
            File.WriteAllLines(annotation_file_location, ai.GetRelativesString().ToArray());
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
