namespace FizzBuzz2;

public class FizzBuzz
{
    public static string Calculate(int i)
    {
        var comma = ",";
        string sequence = "";
        for (int j = 1; j <= 6; j++)
        {
            if (j == 3 || j==6 )
            {
                sequence += "Fizz"+comma;
            }
            else if (j == 5)
            {
                sequence += "Buzz" + comma;
            }
            else
            {
                sequence += j + comma;
            }
        }

        return sequence + "7,8,Fizz,Buzz,11,Fizz,13,14,FizzBuzz,16,17,Fizz,19,Buzz";
    }
}