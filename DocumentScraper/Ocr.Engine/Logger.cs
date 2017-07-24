using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ocr.Engine
{
    public class Log4NetImplementation : ILogger
    {

        private static readonly ILog Log =
              LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public void Message(string log)
        {
            Log.Info(log);
        }
    }

    public interface ILogger
    {
        void Message(string log);
    }
}
