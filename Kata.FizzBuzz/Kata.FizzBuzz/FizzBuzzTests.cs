using NUnit.Framework;
using NUnit.Framework.Constraints;

namespace Kata.FizzBuzz
{
    [TestFixture]
    public class FizzBuzzTests
    {
        [TestCase(1, "1")]
        [TestCase(2, "2")]
        [TestCase(3, "Fizz")]
        [TestCase(5, "Buzz")]
        [TestCase(6, "Fizz")]
        public void FizzBuzz(int n, string expectedResult)
        {
            Assert.That(FizzBuzzer.GetValue(n), Is.EqualTo(expectedResult));
        }
    }

    public class FizzBuzzer
    {
        public static string GetValue(int n)
        {
            if (n == 5) return "Buzz";
            if (n % 3 == 0) return "Fizz";
            return n.ToString();
        }
    }
}
