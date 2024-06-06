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

    public long CalculateMortalRabbitPairs(int months, int lifespan)
    {
        // Initialize a list to store the number of rabbit pairs of each age
        long[] rabbits = new long[lifespan];
        rabbits[0] = 1; // Starting with one pair of newborn rabbits

        for (int month = 1; month < months; month++)
        {
            long newborns = 0;
            for (int i = 1; i < lifespan; i++)
            {
                newborns += rabbits[i];
            }

            // Age the rabbits, move all rabbits one month older
            // Oldest rabbits die, shift the list to the right
            for (int i = lifespan - 1; i > 0; i--)
            {
                rabbits[i] = rabbits[i - 1];
            }
            rabbits[0] = newborns;
        }

        // Total number of rabbits is the sum of all age groups
        return rabbits.Sum();
    }

    public long MortalFibonacciRabbits(int months, int lifespan)
    {
        // Initialize a list to store the number of rabbit pairs of each age
        long[] rabbits = new long[lifespan];
        rabbits[0] = 1; // Starting with one pair of newborn rabbits

        for (int month = 1; month < months; month++)
        {
            long newborns = 0;
            for (int i = 1; i < lifespan; i++)
            {
                newborns += rabbits[i];
            }

            // Age the rabbits, move all rabbits one month older
            // Oldest rabbits die, shift the list to the right
            for (int i = lifespan - 1; i > 0; i--)
            {
                rabbits[i] = rabbits[i - 1];
            }
            rabbits[0] = newborns;
        }

        // Total number of rabbits is the sum of all age groups
        return rabbits.Sum();
    }
}