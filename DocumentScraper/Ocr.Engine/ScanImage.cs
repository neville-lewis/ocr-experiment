using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using asprise_ocr_api;

namespace Ocr.Engine
{
    public class ScanImage : StepChain
    {

        private List<string> _scanWords ;
        private AspriseOCR _ocr;

        public ScanImage()
        {
            _scanWords = new List<string>();
            _scanWords.Add("MV-34");
            _scanWords.Add("MV-34");

            AspriseOCR.SetUp();
            _ocr = new AspriseOCR();
            _ocr.StartEngine("eng", AspriseOCR.SPEED_FASTEST);
        }

        public override void Process(List<string> files)
        {

            //perform scan action for each file
            foreach(string file in files)
            {
                searchKeyWord(file);
                CallNextStep();
            }

            _ocr.StopEngine();
        }


        private bool searchKeyWord(string imageFile)
        {
            string dataExtracted;

            //run thru each of the keywords
            foreach (string scanWord in _scanWords)
            {
                dataExtracted = _ocr.Recognize(imageFile, -1, -1, -1, -1, -1, AspriseOCR.RECOGNIZE_TYPE_ALL, AspriseOCR.OUTPUT_FORMAT_PLAINTEXT);
                if (dataExtracted.Contains(scanWord)) { return true; }
            }

            return false;
        }
    }
}
