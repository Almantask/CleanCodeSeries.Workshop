using CleanCodeSeries.Workshop.Lesson3.EasyOOP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
