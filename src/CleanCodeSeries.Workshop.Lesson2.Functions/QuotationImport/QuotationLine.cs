namespace CleanCodeSeries.Workshop.Lesson2.Functions.EventHandlers
{
    public class QuotationLine
    {
        public int LineNumber;
        public string ItemCode;
        public int ItemCount;

        public QuotationLine(int lineNumber, string itemCode, int itemCount)
        {
            LineNumber = lineNumber;
            ItemCode = itemCode;
            ItemCount = itemCount;
        }
    }
}