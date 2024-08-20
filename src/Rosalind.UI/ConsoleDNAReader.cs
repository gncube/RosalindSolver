using Rosalind.UI.Services;

namespace Rosalind.UI;

public class ConsoleDNAReader : IDNAReader
{
    public string ReadDNA()
    {
        Console.WriteLine("Counting DNA Nucleotides! Using Console");
        Console.WriteLine("Enter a DNA string: ");
        return Console.ReadLine() ?? string.Empty;
    }
}