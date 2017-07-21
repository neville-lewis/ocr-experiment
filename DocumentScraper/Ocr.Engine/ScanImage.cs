using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using asprise_ocr_api;

namespace Ocr.Engine
{
    public class ScanImageForKeyWords : StepChain
    {

        private List<string> _scanWords ;

        
        private IOcr _ocr;

       

        public ScanImageForKeyWords(IOcr ocr)
        {
            _scanWords = new List<string>();

            //get these from config
            _scanWords.Add("MV-34");
            _scanWords.Add("Change of Address Affidavit");
            _scanWords.Add("Chang. of Addy");
            _scanWords.Add("Address Affidavit");
            _scanWords.Add("Affidavit");

            _flaggedFiles = new List<FlaggedFilesDto>();
            _ocr = ocr;
 
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="files"></param>
        public override void Process(List<string> files)
        {
            int pageNum = 1;

            //perform scan action for each image file extracted from the pdf
            foreach(string file in files)
            {
                //When any of the predefined keywords found in the current image file.
                if (searchKeyWord(file))
                {
                    var item = new FlaggedFilesDto() { FilePath = file.Split(new[] { "-_-" }, StringSplitOptions.None)[0], PageNum = pageNum };
                    
                    //only add if this has not been added before.
                    if (!_flaggedFiles.Contains(item))
                    {
                        _flaggedFiles.Add(item);
                    }
                }
                pageNum++;
            }

            //delete the image files recieved in this step
            Files = files;
            CallNextStep();

            //_ocr.Cleanup();
        }


        private bool searchKeyWord(string imageFile)
        {
            string dataExtracted = _ocr.GetTextFromImage(imageFile);

            //run thru each of the keywords
            foreach (string scanWord in _scanWords)
            {
                if (dataExtracted.Contains(scanWord))
                {
                    return true;
                }
            }

            return false;
        }
    }
}
