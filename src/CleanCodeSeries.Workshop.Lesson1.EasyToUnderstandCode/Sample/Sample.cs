using System.Collections.Generic;

namespace CleanCodeSeries.Workshop.Lesson1.EasyToUnderstandCode.Sample
{
    public class FinancialEntry
    {
        public FEHeader Header;
        public IEnumerable<FELine> Lines;

        public FinancialEntry(FEHeader header)
        {
            Header = header;
            Lines = new List<FELine>();
        }

        
    }
}
