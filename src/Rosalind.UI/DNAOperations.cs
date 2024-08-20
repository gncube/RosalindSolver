namespace Rosalind.UI;
public class CountNucleotidesOperation : IOperation
{
    private readonly IDNAProcessor _dnaProcessor;
    private readonly string _dna;

    public CountNucleotidesOperation(IDNAProcessor dnaProcessor, string dna)
    {
        _dnaProcessor = dnaProcessor;
        _dna = dna;
    }

    public void Execute()
    {
        var count = _dnaProcessor.CountNucleotides(_dna);
        Console.WriteLine($"A: {count.A}");
        Console.WriteLine($"C: {count.C}");
        Console.WriteLine($"G: {count.G}");
        Console.WriteLine($"T: {count.T}");
    }
}

public class TranscribeDNAOperation : IOperation
{
    private readonly IDNAProcessor _dnaProcessor;
    private readonly string _dna;

    public TranscribeDNAOperation(IDNAProcessor dnaProcessor, string dna)
    {
        _dnaProcessor = dnaProcessor;
        _dna = dna;
    }

    public void Execute()
    {
        var rna = _dnaProcessor.Transcribe(_dna);
        Console.WriteLine($"RNA: {rna}");
    }
}

public class FindComplementOperation : IOperation
{
    private readonly IDNAProcessor _dnaProcessor;
    private readonly string _dna;

    public FindComplementOperation(IDNAProcessor dnaProcessor, string dna)
    {
        _dnaProcessor = dnaProcessor;
        _dna = dna;
    }

    public void Execute()
    {
        var complement = _dnaProcessor.Complement(_dna);
        Console.WriteLine($"Complement: {complement}");
    }
}

