using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCodeSeries.Workshop.Lesson1.EasyToUnderstandCode.PoorCommenting
{
    static class Calculator
    {
        // Adds two numbers together
        public static decimal Add(decimal n1, decimal n2) => n1 + n2;
        /// <summary>
        /// Substracts first number from second
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <returns></returns>
        public static decimal Substract(decimal n1, decimal n2) => n1 - n2;
        // Muls the two
        public static decimal Mul(decimal n1, decimal n2) => n1 * n2;
        // Division
        public static decimal Div(decimal n1, decimal n2) => n1 / n2;

        public static void Test()
        {
            // var a = Add(5, 7);
        }
    }
}
