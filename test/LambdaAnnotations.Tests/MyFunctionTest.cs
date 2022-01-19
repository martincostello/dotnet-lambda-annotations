using Xunit;

namespace LambdaAnnotations;

public class MyFunctionTest
{
    [Fact]
    public void TestToUpperFunction()
    {
        // Arrange
        var function = new MyFunction();

        // Act
        var upperCase = function.ToUpper("hello world");

        // Assert
        Assert.Equal("HELLO WORLD", upperCase);
    }
}
