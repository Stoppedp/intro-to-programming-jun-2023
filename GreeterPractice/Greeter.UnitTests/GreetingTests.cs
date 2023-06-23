

namespace Greeter.UnitTests;
public class GreetingTests
{
    [Theory]
    [InlineData("Windom", "Hello, Windom.")]
    [InlineData("Jim", "Hello, Jim.")]
    [InlineData(null, "Hello, Chief!")]
    [InlineData("JANE", "HELLO, JANE!")]
    public void SingleName(string name, string expected)
    {
        var greeter = new GreetingMaker();


        string greeting = greeter.Greet(name) ;

        Assert.Equal(expected, greeting);
    }
}





[Theory]
[InlineData("Windom", "Gordon", "Hello, Windom, and Gordon!")]
[InlineData("Cooper", "Truman", "Hello, Cooper, and Truman!")]
[InlineData("Cooper", "Hawk", "Hello, Cooper, and Hawk!")]

public void TwoNames(string name1, string name2, string expected)
{
   
    string greeting = greeter.Greet(name1, name2);

    Assert.Equal(expected, greeting);
}
