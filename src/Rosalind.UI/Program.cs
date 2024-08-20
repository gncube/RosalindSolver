
using Rosalind.UI;
using System.IO.Abstractions;


var dnaProcessor = new DNAProcessor();
var userInputHandler = new UserInputHandler();
var fileSystem = new FileSystem();
var operationFactory = new OperationFactory(dnaProcessor, userInputHandler, fileSystem);

while (true)
{
    DisplayOptions();
    var choice = Console.ReadLine();

    if (choice == "0")
    {
        Console.WriteLine("Exiting the program.");
        break;
    }

    try
    {
        var operation = operationFactory.CreateOperation(choice);
        operation.Execute();
    }
    catch (ArgumentException ex)
    {
        Console.WriteLine(ex.Message);
    }

    Console.WriteLine();
    Console.WriteLine("Operation completed. Do you want to perform another operation? (yes/no)");
    var continueChoice = Console.ReadLine();
    if (continueChoice?.ToLower() != "yes")
    {
        Console.WriteLine("Exiting the program.");
        break;
    }
}

void DisplayOptions()
{
    Console.WriteLine("Select an operation:");
    Console.WriteLine("0. Exit");
    Console.WriteLine("1. Count nucleotides");
    Console.WriteLine("2. Transcribe DNA into RNA");
    Console.WriteLine("3. Find the complement of DNA");
    Console.WriteLine("4. Calculate rabbit pairs");
    Console.WriteLine("5. Calculate mortal rabbit pairs");
    Console.WriteLine("6. Compute highest GC content");
    Console.Write("Enter your choice: ");
}
