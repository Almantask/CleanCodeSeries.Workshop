using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCodeSeries.Workshop.Lesson1.EasyToUnderstandCode.BadNaming
{
    public static class Iterator
    {
        public static void Iterate<T>(IEnumerable<T> collection, int times)
        {
            for (var time = 0; time < times; time++)
            {
                foreach (var VARIABLE in collection)
                {
                    Console.WriteLine($"{VARIABLE}");
                }
            }
        }
    }
}
