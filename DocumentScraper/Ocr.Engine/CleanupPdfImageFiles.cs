using System;
using System.Collections.Generic;
using System.IO;

namespace Ocr.Engine
{
    public class CleanupPdfImageFiles : StepChain
    {
        private IOcr _ocr;

        public CleanupPdfImageFiles(IOcr ocr)
        {
            _ocr = ocr;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="files"></param>
        public override void Process(List<string> files)
        {
            _ocr.Cleanup();
            //delete extracted image files here
            foreach (string f in files)
            {
                File.Delete(f);
            }
        }
    }
}