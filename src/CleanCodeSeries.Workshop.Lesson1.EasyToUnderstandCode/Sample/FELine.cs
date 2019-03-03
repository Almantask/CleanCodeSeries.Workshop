namespace CleanCodeSeries.Workshop.Lesson1.EasyToUnderstandCode.Sample
{
    public class FELine
    {
        public FELine(string id, string description, decimal price)
        {
            Id = id;
            Description = description;
            Price = price;
        }

        public string Id { get; }

        public string Description { set; get; }
        public decimal Price { set; get; }
    }
}