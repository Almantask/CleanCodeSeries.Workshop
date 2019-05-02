using Moq;
using System;

namespace CleanCodeSeries.Workshop.Lesson8.Testing.Web
{
    public class FileReaderTestFixture : IDisposable
    {
        public IFileReader FileReader { get; }

        public FileReaderTestFixture()
        {
            var mock = new Mock<IFileReader>();
            mock.Setup(m => m.Read(It.IsAny<string>())).Returns("Hello World");
            FileReader = mock.Object;
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}