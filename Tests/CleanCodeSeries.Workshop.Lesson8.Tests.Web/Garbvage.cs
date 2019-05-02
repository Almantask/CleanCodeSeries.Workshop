using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace CleanCodeSeries.Workshop.Lesson8.Testing.Web
{
    public class FileStatisticsTests : IClassFixture<FileReaderTestFixture>
    {
        private IFileReader _fileReader;
        FileStatisticsTests(FileReaderTestFixture fixture)
        {
            _fileReader = fixture.FileReader;
        }

        [Fact]
        public void Files_Filed_Stats_Ok()
        {
            var files = new[] { "Test1.txt", "Test2.txt", "Test3.txt", "Test4.txt" };
            var statsProcessor = new StatsProcessor(files);
            var commonWord = statsProcessor.GetCommonWord();
            Assert.Equal("Hello", commonWord);
        }
    }
}
