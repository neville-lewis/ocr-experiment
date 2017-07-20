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


            //Files = new List<string>();

            //-Convert pdf file to images here

            //add converted files and path to list
            Files.Add("Image file 1");
            Files.Add("Image file 2");


            CallNextStep();
            //throw new NotImplementedException();
        }
    }
}
