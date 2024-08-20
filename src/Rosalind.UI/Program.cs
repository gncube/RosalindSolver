
using Rosalind.UI;
using System.IO.Abstractions;


var dnaProcessor = new DNAProcessor();
var userInputHandler = new UserInputHandler();
var fileSystem = new FileSystem();
var operationFactory = new OperationFactory(dnaProcessor, userInputHandler, fileSystem);

Console.Write("Enter 1 to count nucleotides, 2 to transcribe DNA into RNA, 3 to find the complement of DNA, 4 to calculate rabbit pairs, 5 to calculate mortal rabbit pairs: ");
var choice = Console.ReadLine();

try
{
    var operation = operationFactory.CreateOperation(choice);
    operation.Execute();
}
catch (ArgumentException ex)
{
    Console.WriteLine(ex.Message);
}
