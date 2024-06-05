namespace Rosalind.UI;

public class RabbitCalculator : IRabbitCalculator
{
    public long CalculateRabbitPairs(int months, int litterSize)
    {
        if (months == 1 || months == 2)
        {
            return 1;
        }
        else
        {
            return CalculateRabbitPairs(months - 1, litterSize) +
                   litterSize * CalculateRabbitPairs(months - 2, litterSize);
        }
    }

    public long CalculateMortalRabbitPairs(int months, int litterSize, int lifespan)
    {
        throw new NotImplementedException();
    }
}