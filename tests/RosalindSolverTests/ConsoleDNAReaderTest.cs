using FluentAssertions;
using Rosalind.UI;

namespace RosalindSolverTests;

public class ConsoleDNAReaderTest
{

    [Fact]
    public void ReadDNA_GivenInput_ReturnsCorrectString()
    {
        // Arrange
        var input = "AGCT";
        var reader = new StringReader(input);
        Console.SetIn(reader);
        var dnaReader = new ConsoleDNAReader();

        // Act
        var result = dnaReader.ReadDNA();

        // Assert
        result.Should().Be(input);
    }
}