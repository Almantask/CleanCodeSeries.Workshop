using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCodeSeries.Workshop.Lesson4.SOLID
{
    /// <summary>
    /// Singleton implementation of a logging service. Singleton, because we won't be.
    /// We had 2 choices here: either have a static class and set implementation of a static property.
    /// But with static class we cannot abstract it. We don't want that, if we want to test or have easy changes.
    /// </summary>
    public class LoggingService : ILoggingService
    {
        /// <summary>
        /// Component which is doing the actual logging.
        /// </summary>
        private ILogger _logger;

        /// <summary>
        /// Essential part of singleton- instance to yourself.
        /// </summary>
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

        /// <summary>
        /// DI through method injection to register a logging implementation.
        /// </summary>
        /// <param name="logger"></param>
        public void SetLogger(ILogger logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// Logging using logger abstraction
        /// </summary>
        public void Log(string message)
        {
            if (_logger == null)
                throw new Exception("Logger needs to be set before logging");

            _logger.Log(message);
        }
    }
}
