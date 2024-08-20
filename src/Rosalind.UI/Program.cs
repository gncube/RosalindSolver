
using Rosalind.UI;
using System.IO.Abstractions;

//IDNAReader dnaReader = new ConsoleDNAReader();
IDNAReader dnaReader = new FileDNAReader("C:\\REPOS\\RosalindSolver\\tests\\RosalindSolverTests\\dna.txt", new FileSystem());

var dna = dnaReader.ReadDNA();
var dnaProcessor = new DNAProcessor();

Console.Write("Enter 1 to count nucleotides, 2 to transcribe DNA into RNA, 3 to find the complement of DNA, 4 to calculate rabbit pairs, 5 to calculate mortal rabbit pairs: ");
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
            GetRabbitPairs();
            break;

        case "5":
            GetMortalRabbitPairs();
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

static void GetRabbitPairs()
{
    Console.Write("Enter the number of months: ");
    var months = int.Parse(Console.ReadLine());
    Console.Write("Enter the number of offspring: ");
    var offspring = int.Parse(Console.ReadLine());
    var rabbitCalculator = new RabbitCalculator();
    var rabbitPairs = rabbitCalculator.CalculateRabbitPairs(months, offspring);
    Console.WriteLine($"Total rabbit pairs: {rabbitPairs}");
}

static void GetMortalRabbitPairs()
{
    Console.Write("Enter the number of months: ");
    var months = int.Parse(Console.ReadLine());
    Console.Write("Enter the lifespan of rabbits: ");
    var lifespan = int.Parse(Console.ReadLine());
    var rabbitCalculator = new RabbitCalculator();
    var rabbitPairs = rabbitCalculator.CalculateMortalRabbitPairs(months, lifespan);
    Console.WriteLine($"Total rabbit pairs: {rabbitPairs}");
}

Console.WriteLine("This is the answer for Question");
IDNAReader dnaFASTAReader = new FileDNAReader("C:\\REPOS\\RosalindSolver\\tests\\RosalindSolverTests\\Data\\rosalind_gc.txt", new FileSystem());

var fastaStrings = dnaFASTAReader.ReadDNA();

var result = dnaProcessor.ComputeHighestGCContent(fastaStrings);

Console.WriteLine(result.Label.ToString());
Console.WriteLine(result.GCContent);

