using CleanCodeSeries.Workshop.Lesson4.EasyOOP;
using System;

namespace CleanCodeSeries.Workshop.Lesson4.SOLID
{
    /// <summary>
    /// Special randomiser, when it's likely for a choice to be closer to 0.
    /// </summary>
    public class RandomiserHalfed : IRandom
    {
        private Random _random = new Random();
        public int Next(int value)
        {
            return _random.Next(value) / 2;
        }
    }
}
