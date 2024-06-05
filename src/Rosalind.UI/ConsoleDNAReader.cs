namespace Rosalind.UI;

public class ConsoleDNAReader : IDNAReader
{
    public string ReadDNA()
    {
        Console.WriteLine("Enter a DNA string: ");
        return Console.ReadLine() ?? string.Empty;
    }
}
