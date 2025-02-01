namespace factorial_library.Tests;

public class FactorialLibraryTest
{
    [Fact]
    public void Test1()
    {
        var result = FactorialLibraryTest.factorial_function(0);
        Assert.Equal(1, result);
    }
}