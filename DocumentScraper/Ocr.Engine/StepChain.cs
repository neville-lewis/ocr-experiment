﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ocr.Engine
{
    public abstract class StepChain
    {
        public List<string> Files;

        public string FolderName;

        protected StepChain NextStep;
        public void SetNextStep(StepChain step)
        {
            this.NextStep = step;
            this.NextStep.Files = this.Files;
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