using FluentAssertions;
using TestNuget;

namespace TestProject1;

public class UnitTest1
{
    [Fact]
    public void AddTest()
    {
        // Arrange
        int a = 1;
        int b = 2;
        // Act
        var result = AdderUtil.Add(a, b);
        // Assert
        result.Should().Be(3);
    }

    [Fact]
    public void MultiplyTest()
    {
        // Arrange
        int a = 2;
        int b = 3;
        // Act
        var result = AdderUtil.multiply(a, b);
        // Assert
        result.Should().Be(7);
    }
    
}