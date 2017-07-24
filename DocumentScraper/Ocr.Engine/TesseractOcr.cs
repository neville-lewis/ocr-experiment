using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tesseract;

namespace Ocr.Engine
{
    public class Tess : IOcr 
    {

        private TesseractEngine _tessEngine;

        public Tess()
        {
            _tessEngine = new TesseractEngine(@"C:\Tools\tesseract-ocr-dotnet-master\tesseract-ocr-dotnet-master\tessdata", "eng", EngineMode.TesseractAndCube);
        }

        public string GetTextFromImage(string path)
        {

            var image = new Bitmap(path);

            var page = _tessEngine.Process(image, PageSegMode.SingleBlock);

            var textData = page.GetText();
            image.Dispose();
            page.Dispose();
            return textData;
        }



        public void Cleanup()
        {
            _tessEngine.Dispose();
        }
    }
}
