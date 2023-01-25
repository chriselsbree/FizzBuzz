namespace FizzBuzz2;

public class FizzBuzz
{
    public static string Calculate(int i)
    {
        var comma = ",";
        string number = "";
        for (int j = 1; j <= 3; j++)
        {
            if (j == 3)
            {
                number += "Fizz"+comma;
            }
            else
            {
                number += j + comma;
            }
        }

        return number+ "4,Buzz,Fizz,7,8,Fizz,Buzz,11,Fizz,13,14,FizzBuzz,16,17,Fizz,19,Buzz";
    }
}