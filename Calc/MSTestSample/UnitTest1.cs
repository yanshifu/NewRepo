using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MSTestSample
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Calc.Calculator calculator = new Calc.Calculator();
            var result = calculator.Sum(4, 5, 6);
            Assert.AreEqual<int>(15, result);
        }
    }
}
