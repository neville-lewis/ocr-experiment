using System;

namespace Ocr.Engine
{

    public class ProcessedFileEventDataArgs : EventArgs
    {
        public ProcessedFilesDto Data { get; set; }
    }

    public class FlaggedFileEventDataArgs : EventArgs
    {
        public FlaggedFilesDto Data { get;set;}
    }



}