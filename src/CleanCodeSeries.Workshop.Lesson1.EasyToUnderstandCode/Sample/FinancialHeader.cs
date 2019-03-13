using System;

namespace CleanCodeSeries.Workshop.Lesson1.EasyToUnderstandCode.Sample
{
    [Serializable]
    public struct FinancialHeader
    {
        public string Id { get; }

        public string Description { set; get; }
        public decimal Price { set; get; }

        public FinancialHeader(string id, string description, decimal price)
        {
            Id = id;
            Description = description;
            Price = price;
        }
    }
}