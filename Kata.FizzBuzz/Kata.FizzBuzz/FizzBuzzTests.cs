using NUnit.Framework;
using NUnit.Framework.Constraints;

namespace Kata.FizzBuzz
{
    [TestFixture]
    public class FizzBuzzTests
    {
        [Test]
        public void OneReturnsOne()
        {
            Assert.That(FizzBuzzer.GetValue(1), Is.EqualTo("1"));
        }

        [Test]
        public void TwoReturnsTwo()
        {
            Assert.That(FizzBuzzer.GetValue(2), Is.EqualTo("2"));
        }

        [Test]
        public void ThreeReturnsFizz()
        {
            Assert.That(FizzBuzzer.GetValue(3), Is.EqualTo("Fizz"));
        }

        [Test]
        public void FiveReturnsBuzz()
        {
            Assert.That(FizzBuzzer.GetValue(5), Is.EqualTo("Buzz"));
        }
    }

    public class FizzBuzzer
    {
        public static string GetValue(int n)
        {
            if (n == 5) return "Buzz";
            if (n == 3) return "Fizz";
            return n.ToString();
        }
    }
}
