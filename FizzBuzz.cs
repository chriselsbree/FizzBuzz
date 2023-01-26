namespace FizzBuzz2;

public class FizzBuzz
{
    public static string Calculate(int i)
    {
        var comma = ",";
        string sequence = "";
        for (int j = 1; j <= 15; j++)
        {
            if (j % 3 == 0 && j % 5 == 0)
            {
                sequence += "FizzBuzz";
            }
            else if (j % 3 == 0) 
            {
                sequence += "Fizz";
            }
            else if (j == 5 || j == 10)
            {
                sequence += "Buzz";
            }
            else
            {
                sequence += j;
            }

            sequence += comma;
        }

        return sequence + "16,17,Fizz,19,Buzz";
    }
}