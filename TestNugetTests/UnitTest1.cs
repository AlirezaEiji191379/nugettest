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
}