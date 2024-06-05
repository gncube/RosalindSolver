
using Rosalind.UI;

Console.WriteLine("Counting DNA Nucleotides!");
//Console.WriteLine("Enter a DNA string: ");
//var dna = Console.ReadLine();

IDNAReader dnaReader = new ConsoleDNAReader();

var dna = dnaReader.ReadDNA();
var dnaProcessor = new DNAProcessor();
try
{
    var count = dnaProcessor.CountNucleotides(dna);

    Console.WriteLine($"A: {count.A}");
    Console.WriteLine($"C: {count.C}");
    Console.WriteLine($"G: {count.G}");
    Console.WriteLine($"T: {count.T}");

    Console.WriteLine($"{count.A}  {count.C}   {count.G}   {count.T}");
}
catch (ArgumentException ex)
{
    Console.WriteLine(ex.Message);
}

