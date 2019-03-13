using System.Threading;

namespace CleanCodeSeries.Workshop.Lesson1.EasyToUnderstandCode.PoorCommenting
{
    static class Calculator
    {
        public static decimal Add(decimal n1, decimal n2) => n1 + n2;
        public static decimal Substract(decimal n1, decimal n2) => n1 - n2;
        public static decimal Multiply(decimal n1, decimal n2) => n1 * n2;
        public static decimal Divide(decimal n1, decimal n2) => n1 / n2;

        public static void TestWithDelay(int delayMiliseconds)
        {
            Thread.Sleep(delayMiliseconds);
            var a = Add(5, 7);
        }
    }
}
