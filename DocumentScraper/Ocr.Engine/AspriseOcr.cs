using asprise_ocr_api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ocr.Engine
{
    public class Asprise : IOcr, IDisposable
    {
        private AspriseOCR _ocr;
        public Asprise()
        {
            AspriseOCR.SetUp();
            _ocr = new AspriseOCR();
            _ocr.StartEngine("eng", AspriseOCR.SPEED_FASTEST);
        }

 
        public string GetTextFromImage(string pathToImageFile)
        {

            return _ocr.Recognize(pathToImageFile, -1, -1, -1, -1, -1, AspriseOCR.RECOGNIZE_TYPE_ALL, AspriseOCR.OUTPUT_FORMAT_PLAINTEXT); ;
        }

        public void Dispose()
        {
            _ocr.StopEngine();
        }


        public void Cleanup()
        {
            Dispose();
        }
    }
}
