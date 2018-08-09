using System.Runtime.Remoting.Messaging;
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
        [TestCase(10, "Buzz")]
        [TestCase(15, "FizzBuzz")]
        public void FizzBuzz(int n, string expectedResult)
        {
            Assert.That(FizzBuzzer.GetValue(n), Is.EqualTo(expectedResult));
        }
    }

    public class FizzBuzzer
    {
        public static string GetValue(int n)
        {
            if (IsDisivisibleByThree(n) && IsDivisibleByFive(n)) return "FizzBuzz";
            if (IsDisivisibleByThree(n)) return "Fizz";
            if (IsDivisibleByFive(n)) return "Buzz";
            return n.ToString();
        }

        private static bool IsDisivisibleByThree(int n)
        {
            return n % 3 == 0;
        }

        private static bool IsDivisibleByFive(int n)
        {
            return n % 5 == 0;
        }
    }
}
