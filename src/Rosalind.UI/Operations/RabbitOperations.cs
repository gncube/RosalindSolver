using Rosalind.UI.Services;

namespace Rosalind.UI.Operations;
public class GetRabbitPairsOperation : IOperation
{
    private readonly RabbitCalculator _rabbitCalculator;
    private readonly UserInputHandler _userInputHandler;

    public GetRabbitPairsOperation(UserInputHandler userInputHandler)
    {
        _rabbitCalculator = new RabbitCalculator();
        _userInputHandler = userInputHandler;
    }

    public void Execute()
    {
        int months = _userInputHandler.GetIntInput("Enter the number of months: ");
        int offspring = _userInputHandler.GetIntInput("Enter the number of offspring: ");
        var rabbitPairs = _rabbitCalculator.CalculateRabbitPairs(months, offspring);
        Console.WriteLine($"Total rabbit pairs: {rabbitPairs}");
    }

    public bool RequiresDNAString() => false;
}

public class GetMortalRabbitPairsOperation : IOperation
{
    private readonly RabbitCalculator _rabbitCalculator;
    private readonly UserInputHandler _userInputHandler;
    public bool RequiresDNAString() => false;

    public GetMortalRabbitPairsOperation(UserInputHandler userInputHandler)
    {
        _rabbitCalculator = new RabbitCalculator();
        _userInputHandler = userInputHandler;
    }

    public void Execute()
    {
        int months = _userInputHandler.GetIntInput("Enter the number of months: ");
        int lifespan = _userInputHandler.GetIntInput("Enter the lifespan of rabbits: ");
        var rabbitPairs = _rabbitCalculator.CalculateMortalRabbitPairs(months, lifespan);
        Console.WriteLine($"Total rabbit pairs: {rabbitPairs}");
    }
}

