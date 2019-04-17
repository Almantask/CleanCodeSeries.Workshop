using CleanCodeSeries.Workshop.Lesson4.EasyOOP;
using System;

namespace CleanCodeSeries.Workshop.Lesson4.SOLID
{
    /// <summary>
    /// Randomiser for testing missing or having a condition to enforce missing or making a bad choice.
    /// </summary>
    public class RandomiserZero : IRandom
    {
        private Random _random = new Random();
        public int Next(int value) => 0;
    }
}
