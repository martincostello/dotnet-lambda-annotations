using Xunit;

namespace LambdaAnnotations;

public class MathsFunctionsTest
{
    [Fact]
    public void Add_Adds_Numbers()
    {
        // Arrange
        var function = new MathsFunctions();

        // Act
        var actual = function.Add(1, 2);

        // Assert
        Assert.Equal(3, actual);
    }

    [Fact]
    public void Subtract_Subtracts_Numbers()
    {
        // Arrange
        var function = new MathsFunctions();

        // Act
        var actual = function.Subtract(1, 2);

        // Assert
        Assert.Equal(-1, actual);
    }
}
