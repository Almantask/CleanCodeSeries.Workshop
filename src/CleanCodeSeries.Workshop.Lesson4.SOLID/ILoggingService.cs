namespace CleanCodeSeries.Workshop.Lesson4.SOLID
{
    public interface ILoggingService
    {
        void Log(string message);
        void SetLogger(ILogger logger);
    }
}