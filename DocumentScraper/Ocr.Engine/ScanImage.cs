﻿using System;
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

        
        private IOcr _ocr;



        public ScanImage(IOcr ocr)
        {
            _scanWords = new List<string>();
            _scanWords.Add("MV-34");
            _scanWords.Add("Change of Address Affidavit");
            _scanWords.Add("Chang. of Addy");

            _flaggedFiles= new List<FlaggedFilesDto>();
            _ocr = ocr;
 
        }

        public override void Process(List<string> files)
        {

            //perform scan action for each file
            foreach(string file in files)
            {
                if (searchKeyWord(file))
                {
                    _flaggedFiles.Add(new FlaggedFilesDto() { FilePath = file });
                }
                CallNextStep();
            }

            _ocr.Cleanup();
        }


        private bool searchKeyWord(string imageFile)
        {
            string dataExtracted = _ocr.GetTextFromImage(imageFile);

            //run thru each of the keywords
            foreach (string scanWord in _scanWords)
            {
                //dataExtracted = _ocr.Recognize(imageFile, -1, -1, -1, -1, -1, AspriseOCR.RECOGNIZE_TYPE_ALL, AspriseOCR.OUTPUT_FORMAT_PLAINTEXT);
                if (dataExtracted.Contains(scanWord))
                {
                    return true;
                }
            }

            return false;
        }
    }
}
