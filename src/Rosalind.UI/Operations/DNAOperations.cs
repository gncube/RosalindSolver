using Rosalind.UI.Services;

namespace Rosalind.UI.Operations;
public class CountNucleotidesOperation : IOperation
{
    private readonly IDNAProcessor _dnaProcessor;
    private readonly string _dnaString;

    public CountNucleotidesOperation(IDNAProcessor dnaProcessor, string dnaString)
    {
        _dnaProcessor = dnaProcessor;
        _dnaString = dnaString;
    }

    public void Execute()
    {
        var count = _dnaProcessor.CountNucleotides(_dnaString);
        Console.WriteLine($"A: {count.A}");
        Console.WriteLine($"C: {count.C}");
        Console.WriteLine($"G: {count.G}");
        Console.WriteLine($"T: {count.T}");
    }

    public bool RequiresDNAString() => true;
}

public class TranscribeDNAOperation : IOperation
{
    private readonly IDNAProcessor _dnaProcessor;
    private readonly string _dnaString;

    public TranscribeDNAOperation(IDNAProcessor dnaProcessor, string dnaString)
    {
        _dnaProcessor = dnaProcessor;
        _dnaString = dnaString;
    }

    public void Execute()
    {
        var rna = _dnaProcessor.Transcribe(_dnaString);
        Console.WriteLine($"RNA: {rna}");
    }

    public bool RequiresDNAString() => true;
}

public class FindComplementOperation : IOperation
{
    private readonly IDNAProcessor _dnaProcessor;
    private readonly string _dnaString;

    public FindComplementOperation(IDNAProcessor dnaProcessor, string dnaString)
    {
        _dnaProcessor = dnaProcessor;
        _dnaString = dnaString;
    }

    public void Execute()
    {
        var complement = _dnaProcessor.Complement(_dnaString);
        Console.WriteLine($"Complement: {complement}");
    }

    public bool RequiresDNAString() => true;
}

public class ComputeHighestGCContentOperation : IOperation
{
    private readonly IDNAProcessor _dnaProcessor;
    private readonly string _dnaString;

    public ComputeHighestGCContentOperation(IDNAProcessor dnaProcessor, string dnaString)
    {
        _dnaProcessor = dnaProcessor;
        _dnaString = dnaString;
    }
    public void Execute()
    {
        var result = _dnaProcessor.ComputeHighestGCContent(_dnaString);
        Console.WriteLine(result.Label);
        Console.WriteLine(result.GCContent);
    }

    public bool RequiresDNAString() => true;
}

