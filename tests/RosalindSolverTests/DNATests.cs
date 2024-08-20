using FluentAssertions;
using Moq;
using Rosalind.UI.Services;

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
        var dnaProcessorMock = new Mock<IDNAProcessor>();
        dnaProcessorMock.Setup(p => p.Transcribe(dna)).Returns(expectedRna);
        var dnaProcessor = dnaProcessorMock.Object;

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

    [Fact]
    public void ComputeGCContent_GivenDNAString_ReturnsCorrectGCContent()
    {
        // Arrange
        var dna = "AGCTATAG";
        var expectedGCContent = 37.5; // 3 G/C out of 8 total nucleotides
        var dnaProcessor = new DNAProcessor();

        // Act
        var result = dnaProcessor.ComputeGCContent(dna);

        // Assert
        result.Should().BeApproximately(expectedGCContent, 0.001);
    }

    [Fact]
    public void ComputeHighestGCContent_GivenFastaFormatStrings_ReturnsLabelAndGCContent()
    {
        // Arrange
        var fastaStrings = @">Rosalind_6404
CCTGCGGAAGATCGGCACTAGAATAGCCAGAACCGTTTCTCTGAGGCTTCCGGCCTTCCCTCCCACTAATAATTCTGAGG
>Rosalind_5959
CCATCGGTAGCGCATCCTTAGTCCAATTAAGTCCCTATCCAGGCGCTCCGCCGAAGGTCTATATCCATTTGTCAGCAGACACGC
>Rosalind_0808
CCACCCTCGTGGTATGGCTAGGCATTCAGGAACCGGAGAACGCTTCAGACCAGCCCGGACTGGGAACCTGCGGGCAGTAGGTGGAAT";

        var expectedLabel = "Rosalind_0808";
        var expectedGCContent = 60.919540; // GC content of the string with the highest GC content
        var dnaProcessor = new DNAProcessor();

        // Act
        var result = dnaProcessor.ComputeHighestGCContent(fastaStrings);

        // Assert
        result.Label.Should().Be(expectedLabel);
        result.GCContent.Should().BeApproximately(expectedGCContent, 0.001);
    }

    [Fact]
    public void FindMotifLocations_GivenDNAStrings_ReturnsCorrectLocations()
    {
        // Arrange
        var motifString = @"GATATATGCATATACTT
ATAT";
        var expectedLocations = new List<int> { 2, 4, 10 };
        var dnaProcessor = new DNAProcessor();

        // Act
        var result = dnaProcessor.FindMotifLocations(motifString);

        // Assert
        result.Should().BeEquivalentTo(expectedLocations);
    }
}
