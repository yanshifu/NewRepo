using NUnit.Framework;

namespace NUnitTestSample
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Calc.Calculator calculator = new Calc.Calculator();
            var result = calculator.Sum(5,6,7);
            Assert.AreEqual(18, result);
        }
    }
}