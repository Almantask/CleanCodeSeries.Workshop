using System.Collections.Generic;

namespace CleanCodeSeries.Workshop.Lesson2.Functions.EventHandlers
{
    public class Quotation
    {
        public QuotationHeader Header { get; }

        public IList<QuotationLine> Lines { get; }
    }
}