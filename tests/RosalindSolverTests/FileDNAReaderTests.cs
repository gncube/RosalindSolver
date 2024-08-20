using FluentAssertions;
using Rosalind.UI.Services;
using System.IO.Abstractions.TestingHelpers;

namespace RosalindSolverTests;
public class FileDNAReaderTests
{
    [Fact]
    public void ReadDNA_GivenFile_ReturnsCorrectString()
    {
        // Arrange
        var expectedContent = "AGCT";
        var filePath = "/test/dna.txt";
        var fileSystem = new MockFileSystem();
        fileSystem.AddFile(filePath, new MockFileData(expectedContent));
        var dnaReader = new FileDNAReader(filePath, fileSystem);

        // Act
        var result = dnaReader.ReadDNA();

        // Assert
        result.Should().Be(expectedContent);
    }
}
