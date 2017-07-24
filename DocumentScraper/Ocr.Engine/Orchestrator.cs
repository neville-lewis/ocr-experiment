using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ocr.Engine
{
    public class Orchestrator
    {

        //Orchestrator Events 
        public event FlaggedFileProcessedEventHandler ValueFound;
        public event FileProcessedEventHandler FileProcessed;

        public ILogger _log;


        public Orchestrator()
        {
            _log = new Log4NetImplementation();
        }

        /// <summary>
        /// Scans pdf files for preconfigured search words
        /// </summary>
        /// <param name="files">Provide a list of pdf files to scan</param>
        public List<FlaggedFilesDto> Run(List<string> files)
        {
            //select an OCR provider
            IOcr ocr = new Tess();

            _log.Message("Starting up at: " + DateTime.Now.ToString());
            //setting up the chain of events
            StepChain pdfConversion = new PdfToImage();
            StepChain scanImage = new ScanImageForKeyWords(ocr);
            StepChain deleteImages = new CleanupPdfImageFiles(ocr);

            
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
            _log.Message(e.Status + ": " +e.Data.FilePath+ " at "+ DateTime.Now.ToString());
            FileProcessed(e);
        }

        private void ScanImage_KeyWordDetected(FlaggedFileEventDataArgs e)
        {
            _log.Message("Flagged File: " + e.Data.FilePath + " on Page: " + e.Data.PageNum);
            ValueFound(e);
        }
    }
}


