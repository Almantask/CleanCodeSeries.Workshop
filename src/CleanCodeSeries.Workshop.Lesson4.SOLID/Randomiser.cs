using CleanCodeSeries.Workshop.Lesson4.EasyOOP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCodeSeries.Workshop.Lesson4.SOLID
{
    /// <summary>
    /// Usual randomiser used for random choices. 
    /// </summary>
    public class Randomiser : IRandom
    {
        private Random _random = new Random();
        public int Next(int value)
        {
            return _random.Next(value);
        }
    }
}
