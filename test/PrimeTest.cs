using NUnit.Framework;

namespace csharp_codewars
{
    [TestFixture]
    public class PrimeTest
    {
        private Prime prime;

        [SetUp]
        public void SetUp()
        {
            prime = new Prime();
        }

        [Test]
        public void Test1()
        {
            var result = prime.IsPrime(1);
            Assert.IsFalse(result, "1 should not be prime");
        }
    }
}
