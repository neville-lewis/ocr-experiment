using System;
using System.Collections.Generic;
using System.IO;

namespace Ocr.Engine
{
    public class CleanupPdfImageFiles : StepChain
    {

        public CleanupPdfImageFiles()
        {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="files"></param>
        public override void Process(List<string> files)
        {
            //delete extracted image files here
            foreach (string f in files)
            {
                File.Delete(f);
            }
        }
    }
}