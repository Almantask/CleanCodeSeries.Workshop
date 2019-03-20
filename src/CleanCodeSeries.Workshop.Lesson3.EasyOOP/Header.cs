namespace CleanCodeSeries.Workshop.Lesson3.EasyOOP
{
    struct Header
    {
        private string Name { get; }
        private string Description { get; }

        public Header(string name, string descr)
        {
            Name = name;
            Description = descr;
        }
    }
}