using WindowsFormsApp3.OneArgumentOperation;
using NUnit.Framework;

namespace WindowsFormsApp3.Tests.OneArgumentOperation
{
    [TestFixture]
    public class PowerOfTenCalculatorTests
    {
        [TestCase(0, 1)]
        [TestCase(1.4, 25.1188)]
        [TestCase(-0.5, 0.3162)]
        public void CalculateTest(double firstValue, double expected)
        {
            var calculator = new PowerOfTenCalculator();
            var actualResult = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, actualResult, 0.0001);
        }
    }
}
