
using Rosalind.UI;
using System.IO.Abstractions;

IDNAReader dnaReader = new FileDNAReader("C:\\REPOS\\RosalindSolver\\tests\\RosalindSolverTests\\dna.txt", new FileSystem());

var dna = dnaReader.ReadDNA();
var dnaProcessor = new DNAProcessor();
var dnaOperations = new DNAOperations(dnaProcessor);
var rabbitOperations = new RabbitOperations();
var userInputHandler = new UserInputHandler();

Console.Write("Enter 1 to count nucleotides, 2 to transcribe DNA into RNA, 3 to find the complement of DNA, 4 to calculate rabbit pairs, 5 to calculate mortal rabbit pairs: ");
var choice = Console.ReadLine();

try
{
    ProcessChoice(choice, dnaOperations, rabbitOperations, dna, userInputHandler);
}
catch (ArgumentException ex)
{
    Console.WriteLine(ex.Message);
}


Console.WriteLine("This is the answer for Question");
IDNAReader dnaFASTAReader = new FileDNAReader("C:\\REPOS\\RosalindSolver\\tests\\RosalindSolverTests\\Data\\rosalind_gc.txt", new FileSystem());

var fastaStrings = dnaFASTAReader.ReadDNA();

var result = dnaProcessor.ComputeHighestGCContent(fastaStrings);

Console.WriteLine(result.Label.ToString());
Console.WriteLine(result.GCContent);

static void ProcessChoice(string choice, DNAOperations dnaOperations, RabbitOperations rabbitOperations, string dna, UserInputHandler userInputHandler)
{
    switch (choice)
    {
        case "1":
            dnaOperations.CountNucleotides(dna);
            break;
        case "2":
            dnaOperations.TranscribeDNA(dna);
            break;
        case "3":
            dnaOperations.FindComplement(dna);
            break;
        case "4":
            rabbitOperations.GetRabbitPairs(userInputHandler);
            break;
        case "5":
            rabbitOperations.GetMortalRabbitPairs(userInputHandler);
            break;
        default:
            Console.WriteLine("Invalid choice.");
            break;
    }
}