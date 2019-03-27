using CleanCodeSeries.Workshop.Lesson3.EasyOOP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdWorldWar
{
    class Program
    {
        static void Main(string[] args)
        {
            var war = new War();
            war.Simulate();
            Console.ReadKey();
        }
    }
}
