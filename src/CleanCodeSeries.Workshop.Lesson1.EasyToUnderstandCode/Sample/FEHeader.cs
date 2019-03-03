namespace CleanCodeSeries.Workshop.Lesson1.EasyToUnderstandCode.Sample
{
    public class FEHeader
    {
        public string Id { get; }

        public string Description { set; get; }
        public decimal Price { set; get; }

        public FEHeader(string id, string description, decimal price)
        {
            Id = id;
            Description = description;
            Price = price;
        }
    }
}