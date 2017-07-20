using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ocr.Engine
{
    public class ScanImage : StepChain
    {
        public override void Process(List<string> files)
        {
            //get files from previous step
            List<string> str =files;

            //perform scan action

            CallNextStep();
        }
    }
}
