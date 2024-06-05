
using Rosalind.UI;
using System.IO.Abstractions;

//IDNAReader dnaReader = new ConsoleDNAReader();
IDNAReader dnaReader = new FileDNAReader("C:\\REPOS\\RosalindSolver\\tests\\RosalindSolverTests\\dna.txt", new FileSystem());

var dna = dnaReader.ReadDNA();
IDNAProcessor dnaProcessor = new DNAProcessor();

Console.Write("Enter 1 to count nucleotides, 2 to transcribe DNA into RNA, 3 to find the complement of DNA: ");
var choice = Console.ReadLine();

try
{
    switch (choice)
    {
        case "1":
            CountNucleotides(dnaProcessor, dna);
            break;

        case "2":
            TranscribeDNA(dnaProcessor, dna);
            break;

        case "3":
            FindComplement(dnaProcessor, dna);
            break;

        case "4":
            GetRabbitPairs(out var months, out var offspring, out var rabbitCalculator, out var rabbitPairs);
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

static void CountNucleotides(IDNAProcessor dnaProcessor1, string s)
{
    var count = dnaProcessor1.CountNucleotides(s);
    Console.WriteLine($"A: {count.A}");
    Console.WriteLine($"C: {count.C}");
    Console.WriteLine($"G: {count.G}");
    Console.WriteLine($"T: {count.T}");
    Console.WriteLine($"{count.A}  {count.C}   {count.G}   {count.T}");
}

static void TranscribeDNA(IDNAProcessor dnaProcessor1, string s)
{
    var rna = dnaProcessor1.Transcribe(s);
    Console.WriteLine($"RNA: {rna}");
}

static void FindComplement(IDNAProcessor dnaProcessor1, string s)
{
    var complement = dnaProcessor1.Complement(s);
    Console.WriteLine($"Complement: {complement}");
}

static void GetRabbitPairs(out int months, out int offspring, out RabbitCalculator rabbitCalculator, out long rabbitPairs)
{
    Console.Write("Enter the number of months: ");
    months = int.Parse(Console.ReadLine());
    Console.Write("Enter the number of offspring: ");
    offspring = int.Parse(Console.ReadLine());
    rabbitCalculator = new RabbitCalculator();
    rabbitPairs = rabbitCalculator.CalculateRabbitPairs(months, offspring);
    Console.WriteLine($"Total rabbit pairs: {rabbitPairs}");
}

