
using Rosalind.UI;
using System.IO.Abstractions;

//IDNAReader dnaReader = new ConsoleDNAReader();
IDNAReader dnaReader = new FileDNAReader("C:\\REPOS\\RosalindSolver\\tests\\RosalindSolverTests\\dna.txt", new FileSystem());

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

