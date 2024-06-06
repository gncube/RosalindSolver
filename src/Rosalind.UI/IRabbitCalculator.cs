namespace Rosalind.UI;
public interface IRabbitCalculator
{
    long CalculateRabbitPairs(int months, int litterSize);
    long CalculateMortalRabbitPairs(int months, int lifespan);
}