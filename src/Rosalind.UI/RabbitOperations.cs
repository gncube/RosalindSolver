namespace Rosalind.UI;
public class RabbitOperations
{
    private readonly RabbitCalculator _rabbitCalculator;
    public RabbitOperations()
    {
        _rabbitCalculator = new RabbitCalculator();
    }
    public void GetRabbitPairs(UserInputHandler userInputHandler)
    {
        int months = userInputHandler.GetIntInput("Enter the number of months: ");
        int offspring = userInputHandler.GetIntInput("Enter the number of offspring: ");

        var rabbitPairs = _rabbitCalculator.CalculateRabbitPairs(months, offspring);
        Console.WriteLine($"Total rabbit pairs: {rabbitPairs}");
    }

    public void GetMortalRabbitPairs(UserInputHandler userInputHandler)
    {
        int months = userInputHandler.GetIntInput("Enter the number of months: ");
        int lifespan = userInputHandler.GetIntInput("Enter the lifespan of rabbits: ");

        var rabbitPairs = _rabbitCalculator.CalculateMortalRabbitPairs(months, lifespan);
        Console.WriteLine($"Total rabbit pairs: {rabbitPairs}");
    }
}
