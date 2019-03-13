namespace CleanCodeSeries.Workshop.Lesson1.EasyToUnderstandCode.Sample
{
    public struct FinancialEntryLine
    {
        public readonly string Id;
        public readonly string Description;
        public readonly decimal Price;

        public FinancialEntryLine(string id, string description, decimal price)
        {
            Id = id;
            Description = description;
            Price = price;
        }
    }
}