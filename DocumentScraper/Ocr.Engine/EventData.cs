using System;

namespace Ocr.Engine
{
    public class EventDataArgs : EventArgs
    {
        public FlaggedFilesDto Data { get;set;}
    }
}