using System.Collections.Generic;

namespace CleanCodeSeries.Workshop.Lesson1.EasyToUnderstandCode.Sample
{
    public class FinancialEntry
    {
        public FinancialHeader Header;
        public List<FinancialEntryLine> Lines;

        public FinancialEntry(FinancialHeader header)
        {
            Header = header;
            Lines = new List<FinancialEntryLine>();
        }

        
    }
}
