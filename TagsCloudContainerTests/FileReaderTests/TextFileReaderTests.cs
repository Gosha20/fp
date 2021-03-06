using System.IO;
using FluentAssertions;
using NUnit.Framework;
using TagsCloudContainer;
using TagsCloudContainer.FileReaders;
using TagsCloudContainer.Settings;

namespace TagsCloudContainerTests.FileReaderTests
{
    [TestFixture]
    public class TextFileReaderTests
    {
        [Test]
        public void Read_Should_ReturnAllTextInFile()
        {
            var option = new Option();
            option.InputFileName = @"C:\Users\gosha\Desktop\di\TagsCloudContainerTests\FileReaderTests\file.txt";

            var fileSettings =
                new FileSettings(option);
            var textReader = new TextFileReader(fileSettings);
            var expectedResult =
                File.ReadAllText(@"C:\Users\gosha\Desktop\di\TagsCloudContainerTests\FileReaderTests\file.txt");

            var result = textReader.Read().Value;

            result.Should().BeEquivalentTo(expectedResult);
        }
    }
}