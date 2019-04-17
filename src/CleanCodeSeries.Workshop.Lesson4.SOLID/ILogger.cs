using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCodeSeries.Workshop.Lesson4.SOLID
{
    /// <summary>
    /// SRP: Logger logs.
    /// </summary>
    public interface ILogger
    {
        void Log(string message);
    }
}
