using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

            
            int i = 0;
            //-Convert each pdf file to images here
            foreach (string pdffile in files)
            {

                //add multiple image files from one pdf to list

                i++;
                Files.Add(pdffile + i + " - Image file 1" );
                
                Files.Add(pdffile + i + " - Image file 2" );
                CallNextStep();
                Files.Clear();
            }


           
            //throw new NotImplementedException();
        }
    }
}
