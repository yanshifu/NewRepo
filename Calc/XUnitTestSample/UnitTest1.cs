using System;
using Xunit;

namespace XUnitTestSample
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Calc.Calculator calculator = new Calc.Calculator();
            var result = calculator.Sum(4, 5, 6);
            Assert.Equal<int>(15, result);
        }
        [Theory]
        [InlineData(3,4,7)]
        [InlineData(5,6,11)]
        [InlineData(-5,5,0)]
        public void Test2(int num1, int num2, int expectedResult)
        {
            Calc.Calculator calculator = new Calc.Calculator();
            var result = calculator.Sum(num1, num2);
            Assert.Equal(expectedResult, result);
        }
    }
}
