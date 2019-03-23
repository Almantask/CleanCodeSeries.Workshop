namespace CleanCodeSeries.Workshop.Lesson2.Functions.QuotationImport
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