using FluentAssertions;
using Rosalind.UI;

namespace RosalindSolverTests;
public class RabbitTests
{
    [Fact]
    public void CalculateRabbitPairs_GivenMonthsAndOffspring_ReturnsTotalRabbitPairs()
    {
        // Arrange
        var months = 5;
        var offspring = 3;
        var expectedRabbitPairs = 19;
        var rabbitCalculator = new RabbitCalculator();

        // Act
        var result = rabbitCalculator.CalculateRabbitPairs(months, offspring);

        // Assert
        result.Should().Be(expectedRabbitPairs);
    }
}
