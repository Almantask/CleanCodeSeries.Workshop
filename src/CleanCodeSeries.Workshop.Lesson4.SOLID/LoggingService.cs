using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCodeSeries.Workshop.Lesson4.SOLID
{
    public class LoggingService
    {
        private ILogger _logger;

        private static LoggingService _instance;

        public static LoggingService Instance
        {
            get
            {
                if(_instance == null)
                {
                    _instance = new LoggingService();
                }
                return _instance;
            }
        }

        private LoggingService() { }

        public void SetLogger(ILogger logger)
        {
            _logger = logger;
        }

        public void Log(string message)
        {
            if (_logger == null)
                throw new Exception("Logger needs to be set before logging");

            _logger.Log(message);
        }
    }
}
