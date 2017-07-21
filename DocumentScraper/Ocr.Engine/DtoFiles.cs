using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ocr.Engine
{

    public class ProcessedFilesDto
    {
        public string FilePath { get; set; }
       
    }


    public class FlaggedFilesDto : ProcessedFilesDto
    {
        public int PageNum { get; set; }
    }
}
