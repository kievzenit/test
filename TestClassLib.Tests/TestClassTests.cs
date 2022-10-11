namespace TestClassLib.Tests;

public class TestClassTests
{
    [Theory]
    [InlineData(1, 6, 7)]
    [InlineData(6, -98, 92)]
    [InlineData(5, 7, 12)]
    public void Test_AddMethod(int a, int b, int expected)
    {
        // arrange
        var testClass = new TestClass();

        // act
        var result = testClass.Add(a, b);

        // assert
        result.Should().Be(expected);
    }
}