namespace Rosalind.UI.Services;

public interface IDNAProcessor
{
    NucleotideCount CountNucleotides(string dna);
    string Transcribe(string dna);
    string Complement(string dna);
    double ComputeGCContent(string dna);
    GCContentResult ComputeHighestGCContent(string fastaStrings);
}