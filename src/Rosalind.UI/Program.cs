
using Rosalind.UI;
using System.IO.Abstractions;

//IDNAReader dnaReader = new ConsoleDNAReader();
IDNAReader dnaReader = new FileDNAReader("C:\\REPOS\\RosalindSolver\\tests\\RosalindSolverTests\\dna.txt", new FileSystem());

var dna = dnaReader.ReadDNA();
var dnaProcessor = new DNAProcessor();

Console.Write("Enter 1 to count nucleotides, 2 to transcribe DNA into RNA, 3 to find the complement of DNA: ");
var choice = Console.ReadLine();

try
{
    switch (choice)
    {
        case "1":
            var count = dnaProcessor.CountNucleotides(dna);
            Console.WriteLine($"A: {count.A}");
            Console.WriteLine($"C: {count.C}");
            Console.WriteLine($"G: {count.G}");
            Console.WriteLine($"T: {count.T}");
            Console.WriteLine($"{count.A}  {count.C}   {count.G}   {count.T}");
            break;

        case "2":
            var rna = dnaProcessor.Transcribe(dna);
            Console.WriteLine($"RNA: {rna}");
            break;
        case "3":
            var complement = dnaProcessor.Complement(dna);
            Console.WriteLine($"Complement: {complement}");
            break;
        default:
            Console.WriteLine("Invalid choice.");
            break;
    }


}
catch (ArgumentException ex)
{
    Console.WriteLine(ex.Message);
}

