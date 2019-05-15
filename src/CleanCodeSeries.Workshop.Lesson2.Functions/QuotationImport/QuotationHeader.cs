namespace CleanCodeSeries.Workshop.Lesson2.Functions.EventHandlers
{
    public class QuotationHeader
    {
        public string OrderCode;
        public string StatusCode;

        public QuotationHeader(string orderCode, string statusCode)
        {
            OrderCode = orderCode;
            StatusCode = statusCode;
        }
    }
}