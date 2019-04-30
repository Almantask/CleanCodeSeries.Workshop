using CleanCodeSeries.Workshop.Lesson4.EasyOOP;
using System;

namespace CleanCodeSeries.Lesson4.SOLID.Tests
{
    public class MockedRandomViaOverride:Random, IRandom
    {
        public override int Next(int maxValue)
        {
            return maxValue;
        }
    }

    public class MockedRandomViaInterface : IRandom
    {
        public int Next(int maxValue)
        {
            return maxValue;
        }
    }
}
