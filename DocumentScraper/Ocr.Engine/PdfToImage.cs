using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XsPDF.Pdf;

namespace Ocr.Engine
{
    public class PdfToImage : StepChain
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="files"></param>
        public override void Process(List<string> files)
        {


            Files = new List<string>();

            
            //int i = 0;
            //-Convert each pdf file to images here
            foreach (string pdffile in files)
            {

                //add multiple image files from one pdf to list

                //i++;
                //Files.Add(pdffile + i + " - Image file 1" );

                //Files.Add(pdffile + i + " - Image file 2" );

                Files.AddRange(getImageFile(pdffile));

                CallNextStep();
                Files.Clear();
            }
       }



        private List<string> getImageFile(string pdfFile)
        {
            List<string> imageFiles = new List<string>();
            string imageFilePath;
            PdfImageConverter pdfConverter = new PdfImageConverter(pdfFile);

            // Set the dpi, the output image will be rendered in such resolution
            pdfConverter.DPI = 96;

            for (int i = 0; i < pdfConverter.PageCount; i++)
            {
                // Convert each pdf page to png image with original page size
                Image pageImage = pdfConverter.PageToImage(i);
                // Convert pdf to png in customized image size
                //Image pageImage = pdfConverter.PageToImage(i, 500, 800);

                imageFilePath = pdfFile + "img-" + i + ".png";
                // Save converted image to png format
                pageImage.Save(imageFilePath, ImageFormat.Png);

                imageFiles.Add(imageFilePath);
            }

            return imageFiles;
        }
    }
}
