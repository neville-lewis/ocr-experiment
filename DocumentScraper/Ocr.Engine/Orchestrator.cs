using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ocr.Engine
{
    public class Orchestrator
    {
        public static void Run(List<string> files)
        {
            StepChain start = new PdfToImage();
            StepChain scanImage = new ScanImage(new Asprise());

            start.SetNextStep(scanImage);

            start.Process(files);

        }
    }
}
