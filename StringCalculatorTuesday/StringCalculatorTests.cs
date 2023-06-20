
namespace StringCalculator;

public class StringCalculatorTests
{
    [Fact]
    public void EmptyStringReturnsZero()
    {
        var calculator = new StringCalculator();

        var result = calculator.Add("");

        Assert.Equal(0, result);
    }

    [Fact]
    public void SingleNumberReturnItself()
    {
        var calculator = new StringCalculator();

        var result = calculator.Add("8");

        Assert.Equal(8, result);
    }

    [Fact]
    public void ReturnSum()
    {
        var calculator = new StringCalculator();

        var result = calculator.Add("2,5");

        Assert.Equal(7, result);
    }

}



