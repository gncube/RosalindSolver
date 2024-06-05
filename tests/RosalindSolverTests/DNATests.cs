using FluentAssertions;
using Rosalind.UI;

namespace RosalindSolverTests;

public class DNATests
{
    [Fact]
    public void CountNucleotides_GivenDNAString_ReturnsCorrectNucleotideCounts()
    {
        // Arrange
        var dna = "AGCTTTTCATTCTGACTGCAACGGGCAATATGTCTCTGTGTGGATTAAAAAAAGAGTGTCTGATAGCAGC";
        var dnaProcessor = new DNAProcessor();

        // Act
        var result = dnaProcessor.CountNucleotides(dna);

        // Assert
        result.A.Should().Be(20);
        result.C.Should().Be(12);
        result.G.Should().Be(17);
        result.T.Should().Be(21);
    }
}