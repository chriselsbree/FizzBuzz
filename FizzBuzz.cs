namespace FizzBuzz2;

public class FizzBuzz
{
    public static string Calculate(int i)
    {
        var comma = ",";
        string sequence = "";
        for (int j = 1; j <= i; j++)
        {
            if (j % 3 == 0 && j % 5 == 0)
            {
                sequence += "FizzBuzz";
            }
            else if (j % 3 == 0) 
            {
                sequence += "Fizz";
            }
            else if (j % 5 == 0)
            {
                sequence += "Buzz";
            }
            else
            {
                sequence += j;
            }

            if (j != 20)
            {
                sequence += comma;
            }
        }

        return sequence;
    }
}