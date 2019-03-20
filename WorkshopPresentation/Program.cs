using System;
using System.Collections.Generic;
using System.Data;
using CleanCodeSeries.Workshop.Lesson2.Functions.StaticHelpers;
namespace WorkshopPresentation
{
    class Program
    {
        static void Main(string[] args)
        {
            DemoCollectionPrint();
        }

        private static void DemoCollectionPrint()
        {
            var list = new List<object>() { 1, 2, "a", new DataTable() };
            Array array = new object[] { 1, 2, "a", new DataTable() };



            var message1 = list.Print();
            var message2 = array.Print();

            Console.WriteLine(message1);
            Console.WriteLine(message2);

            Console.ReadLine();
        }
    }
}
