using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ocr.Engine
{
    public class ScanImage : StepChain
    {

        private List<string> _scanWords ;


        public ScanImage()
        {
            _scanWords = new List<string>();
            _scanWords.Add("MV-34");
            _scanWords.Add("MV-34");
        }

        public override void Process(List<string> files)
        {
            //get files from previous step
            List<string> str =files;

            //perform scan action for each file
            foreach(string file in files)
            {
                searchKeyWord(file);
                CallNextStep();
            }
            
        }


        private bool searchKeyWord(string imageFile)
        {
            bool isFound = false;


            return isFound;
        }
    }
}
