using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ocr.Engine
{
    public class Orchestrator
    {


        public event FlaggedFileProcessedEventHandler ValueFound;
        public event FileProcessedEventHandler FileProcessed; 
        /// <summary>
        /// Scans pdf files for preconfigured search words
        /// </summary>
        /// <param name="files">Provide a list of pdf files to scan</param>
        public List<FlaggedFilesDto> Run(List<string> files)
        {
            //select an OCR provider
            IOcr ocr = new Tess();

            //setting up the chain of events
            StepChain pdfConversion = new PdfToImage();
            StepChain scanImage = new ScanImageForKeyWords(ocr);
            StepChain deleteImages = new CleanupPdfImageFiles();

            
            pdfConversion.SetNextStep(scanImage);
            scanImage.SetNextStep(deleteImages);

            scanImage.KeyWordDetected += ScanImage_KeyWordDetected;
            scanImage.FileProcessed += ScanImage_FileProcessed;

            pdfConversion.Process(files);

            ocr.Cleanup();

            return scanImage.FlaggedFiles;
        }

        private void ScanImage_FileProcessed(ProcessedFileEventDataArgs e)
        {
            FileProcessed(e);
        }

        private void ScanImage_KeyWordDetected(FlaggedFileEventDataArgs e)
        {
            ValueFound(e);
        }
    }
}
