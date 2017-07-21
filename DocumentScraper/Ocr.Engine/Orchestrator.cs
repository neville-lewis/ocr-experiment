using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ocr.Engine
{
    public class Orchestrator
    {
        /// <summary>
        /// Scans pdf files for preconfigured search words
        /// </summary>
        /// <param name="files">Provide a list of pdf files to scan</param>
        public static List<FlaggedFilesDto> Run(List<string> files)
        {
            //select an OCR provider
            IOcr ocr = new Tess();

            //setting up the chain of events
            StepChain pdfConversion = new PdfToImage();
            StepChain scanImage = new ScanImageForKeyWords(ocr);
            StepChain deleteImages = new CleanupPdfImageFiles();

            pdfConversion.SetNextStep(scanImage);
            scanImage.SetNextStep(deleteImages);
            
            pdfConversion.Process(files);

            ocr.Cleanup();

            return scanImage.FlaggedFiles;
        }
    }
}
