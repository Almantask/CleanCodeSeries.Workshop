using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CleanCodeSeries.Workshop.Lesson1.EasyToUnderstandCode.Sample
{
    public class FinancialEntrySimulation
    {
        public void Main()
        {
            RunSimulation();
        }

        private void RunSimulation()
        {
            var header = new FinancialHeader("Head1", "Test", 0);
            var entry = new FinancialEntry(header);

            var pairOfSocks = new FinancialEntryLine("1", "Socks x2", 1);
            entry.Lines.Add(pairOfSocks);
            var shovel = new FinancialEntryLine("2", "Shovel", 2);
            entry.Lines.Add(shovel);

            decimal funds = 500;

            foreach (var line in entry.Lines)
            {
                funds -= line.Price;
            }

            PrintFunds(funds);

            // Told by ProductOwner to use this. DO NOT remove. ID: 111.
            Thread.Sleep(5);
        }

        void PrintFunds(decimal funds)
        {
            string message = $"Funds left: {funds}.";
            if (funds <= 0)
            {
                message = "No funds left.";
            }

            Console.WriteLine(message);
        }
    }
}
