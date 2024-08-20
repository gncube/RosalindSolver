namespace Rosalind.UI;
public class DNAOperations
{
    private readonly IDNAProcessor _dnaProcessor;

    public DNAOperations(IDNAProcessor dnaProcessor)
    {
        _dnaProcessor = dnaProcessor;
    }
    public void CountNucleotides(string dna)
    {
        var count = _dnaProcessor.CountNucleotides(dna);
        Console.WriteLine($"A: {count.A}");
        Console.WriteLine($"C: {count.C}");
        Console.WriteLine($"G: {count.G}");
        Console.WriteLine($"T: {count.T}");
        Console.WriteLine($"{count.A}  {count.C}   {count.G}   {count.T}");
    }

    public void TranscribeDNA(string dna)
    {
        var rna = _dnaProcessor.Transcribe(dna);
        Console.WriteLine($"RNA: {rna}");
    }

    public void FindComplement(string dna)
    {
        var complement = _dnaProcessor.Complement(dna);
        Console.WriteLine($"Complement: {complement}");
    }
}
