

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


{
    [Theory]
    
    public void DoubleName(string name1,string name2, string expected)
    {
        var greeter = new GreetingMaker();


        string greeting = greeter.Greet(name);

        Assert.Equal(expected, greeting);
    }
}
