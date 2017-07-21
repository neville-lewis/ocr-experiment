using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ocr.Engine
{
    public abstract class StepChain
    {
        protected List<string> Files;

        protected string FolderName;

        protected StepChain NextStep;

        protected List<FlaggedFilesDto> _flaggedFiles;
        public List<FlaggedFilesDto> FlaggedFiles { get; private set; }
        public void SetNextStep(StepChain step)
        {
            this.NextStep = step;
        }

        protected void CallNextStep()
        {
            if(NextStep != null)
            {
                NextStep.Process(Files);
            }
        }
        public abstract void Process(List<string> files);
    }


}
