using System;

namespace CleanCodeSeries.Workshop.Lesson8.Testing.Web
{
    internal class StatsProcessor
    {
        private string[] files;

        public StatsProcessor(string[] files)
        {
            this.files = files;
        }

        internal object GetCommonWord()
        {
            throw new NotImplementedException();
        }
    }
}