
using CleanCodeSeries.Workshop.Lesson3.EasyOOP;
using CleanCodeSeries.Workshop.Lesson4.SOLID;
using System;

namespace WorkshopPresentation
{
    class Program
    {
        static void Main(string[] args)
        {
            var war = new War(new SoldierGenerator());
            war.Simulate();
            Console.ReadKey();
        }
    }
}
