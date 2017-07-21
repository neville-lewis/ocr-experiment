using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ocr.Engine
{
    public delegate void FlaggedFileProcessedEventHandler(FlaggedFileEventDataArgs e);
    public delegate void FileProcessedEventHandler(ProcessedFileEventDataArgs e);
    
    public abstract class StepChain
    {
        protected List<string> Files;

        protected string FolderName;

        protected StepChain NextStep;

        protected List<FlaggedFilesDto> _flaggedFiles;
        public List<FlaggedFilesDto> FlaggedFiles { get; private set; }


        public event FlaggedFileProcessedEventHandler KeyWordDetected;

        public event FileProcessedEventHandler FileProcessed;

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

        protected virtual void OnKeyWordDetected(FlaggedFileEventDataArgs e)
        {
            KeyWordDetected(e);
        }

        protected virtual void OnFileProcessed(ProcessedFileEventDataArgs e)
        {
            FileProcessed(e);
        }

        public abstract void Process(List<string> files);
    }


}
