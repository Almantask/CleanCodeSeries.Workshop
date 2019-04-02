namespace CleanCodeSeries.Workshop.Lesson4.SOLID.Examples.ISample
{
    interface IInvoiceService
    {
        void Pay(decimal amount);
        void Send(string address);
    }
}