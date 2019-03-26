namespace CleanCodeSeries.Workshop.Lesson3.EasyOOP
{
    class Item
    {
        public string Id { get; }
        public float Price { set; get; }
        public string Description { set; get; }

        public Item(string id, string description, float price)
        {
            Id = id;
            Price = price;
            Description = description;
        }
    }
}