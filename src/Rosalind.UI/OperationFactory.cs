namespace Rosalind.UI;
public class OperationFactory
{
    private readonly IDNAProcessor _dnaProcessor;
    private readonly string _dnaString;
    private readonly UserInputHandler _userInputHandler;

    public OperationFactory(IDNAProcessor dnaProcessor, string dnaString, UserInputHandler userInputHandler)
    {
        _dnaProcessor = dnaProcessor;
        _dnaString = dnaString;
        _userInputHandler = userInputHandler;
    }

    public IOperation CreateOperation(string choice)
    {
        return choice switch
        {
            "1" => new CountNucleotidesOperation(_dnaProcessor, _dnaString),
            "2" => new TranscribeDNAOperation(_dnaProcessor, _dnaString),
            "3" => new FindComplementOperation(_dnaProcessor, _dnaString),
            "4" => new GetRabbitPairsOperation(_userInputHandler),
            "5" => new GetMortalRabbitPairsOperation(_userInputHandler),
            _ => throw new ArgumentException("Invalid choice.")
        };
    }
}

