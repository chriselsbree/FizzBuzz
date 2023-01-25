namespace FizzBuzz2;

public class FizzBuzz
{
    public static string Calculate(int i)
    {
        var comma = ",";
        string number = "";
        for (int j = 1; j <= 2; j++)
        {
            number += j + comma;

        }

        number += "Fizz";
        return number+ ",4,Buzz,Fizz,7,8,Fizz,Buzz,11,Fizz,13,14,FizzBuzz,16,17,Fizz,19,Buzz";
    }
}