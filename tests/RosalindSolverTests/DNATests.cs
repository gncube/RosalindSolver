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


    [Fact]
    public void CountNucleotides_GivenInvalidNucleotide_ThrowsException()
    {
        // Arrange
        var dna = "AGCTZ";
        var dnaProcessor = new DNAProcessor();

        // Act
        Action act = () => dnaProcessor.CountNucleotides(dna);

        // Assert
        act.Should().Throw<ArgumentException>()
            .WithMessage("Invalid nucleotide: Z");
    }

    [Fact]
    public void Transcribe_GivenDNAString_ReturnsRNAString()
    {
        // Arrange
        var dna = "GATGGAACTTGACTACGTAAATT";
        var expectedRna = "GAUGGAACUUGACUACGUAAAUU";
        var dnaProcessor = new DNAProcessor();

        // Act
        var result = dnaProcessor.Transcribe(dna);

        // Assert
        result.Should().Be(expectedRna);
    }

    [Fact]
    public void Complement_GivenDNAString_ReturnsComplementString()
    {
        // Arrange
        var dna = "AAAACCCGGT";
        var expectedComplement = "ACCGGGTTTT";
        var dnaProcessor = new DNAProcessor();

        // Act
        var result = dnaProcessor.Complement(dna);

        // Assert
        result.Should().Be(expectedComplement);
    }
}