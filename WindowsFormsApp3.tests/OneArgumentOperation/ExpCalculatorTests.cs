using WindowsFormsApp3.OneArgumentOperation;
using NUnit.Framework;

namespace WindowsFormsApp3.Tests.OneArgumentOperation
{
    [TestFixture]
    public class ExpCalculatorTests
    {
        [TestCase(1, 2.71)]
        [TestCase(0, 1)]
        [TestCase(-1, 0.36)]
        public void CalculateTest(double firstValue, double expected)
        {
            var calculator = new ExpCalculator();
            var actualResult = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, actualResult, 0.01);
        }
    }
}
