using NuGet.Frameworks;

namespace FizzBuzz2
{
    [TestClass]
    public class FizzBuzzTest
    {
        [TestMethod]
        public void TestFizzBuzz()
        {
            var output = FizzBuzz.Calculate(20);
            string expected = "1,2,Fizz,4,Buzz,Fizz,7,8,Fizz,Buzz,11,Fizz,13,14,FizzBuzz,16,17,Fizz,19,Buzz";
            Assert.AreEqual(expected, output);
        }

        [TestMethod]
        public void TestFizzBuzzWith1()
        {
            var output = FizzBuzz.Calculate(1);
            string expected = "1";
            Assert.AreEqual(expected, output);
        }
    }
}