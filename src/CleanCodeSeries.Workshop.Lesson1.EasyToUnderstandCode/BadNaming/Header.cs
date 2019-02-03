namespace CleanCodeSeries.Workshop.Lesson1.EasyToUnderstandCode.BadNaming
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