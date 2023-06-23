namespace Greeter;

public class GreetingMaker 
{
    public GreetingMaker()
    {

    }

    public string Greet(string name)

    {
        if (name == null)
        {
            return "Hello, Chief!";
        }

        if (name.Equals(name.ToUpper()))
        {
            return "HELLO, " + name + "!";
        }
        else
            return "Hello, " + name + ".";
    }

    public string TwoNames(string name) 
    {
        
    }
}