using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CleanCodeSeries.Workshop.Lesson1.EasyToUnderstandCode.Sample
{
    public class FESimulation
    {
        public void Main()
        {
            decimal f = 500;
            
            var header = new FEHeader("Head1", "Test", 0);
            var entry = new FinancialEntry(header);
            // Price for Socks x2
            ((List<FELine>)entry.Lines).Add(new FELine("1", "Socks x2", 1));
            // Price for Shovel
            ((List<FELine>)entry.Lines).Add(new FELine("2", "Shovel", 2));
            // Price for Bricks x5
            ((List<FELine>)entry.Lines).Add(new FELine("3", "Bricks x5", 3));

            for (var entryInteger = 0; entryInteger < entry.Lines.Count(); entryInteger++)
            {
                var entryFELine = entry.Lines.ToList()[entryInteger]; f -= entryFELine.Price;
            }

            // note about negative
            if (f > 0)
            {
                Console.WriteLine($"Funds left: {f}.");
            }
            else
            {
                Console.WriteLine("No funds left.");
            }

            // Told by PO to use this. DO NOT remove.
            Thread.Sleep(5);

            //int a = 5;
            //a++;
            //Console.WriteLine(a);
        }
    }
}
