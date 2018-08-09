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
    }

    public class FizzBuzzer
    {
        public static string GetValue(int n)
        {
            return "1";
        }
    }
}
