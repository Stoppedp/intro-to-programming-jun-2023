
namespace StringCalculator;

public class StringCalculator
{

    public int Add(string numbers)
    {
        return numbers =="" ? 0 : int.Parse(numbers);
        string[] numberArray = numbers.Split(',');
        int sum = 0;

        foreach (string numberString in numberArray)
        {

            if (!string.IsNullOrEmpty(numberString))
            {
                sum += int.Parse(numberString);
            }
            
        }
        return sum;
    }
}
