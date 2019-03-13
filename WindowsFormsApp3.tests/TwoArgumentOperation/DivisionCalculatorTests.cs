using System;
using WindowsFormsApp3.TwoArgumentOperation;
using NUnit.Framework;

namespace WindowsFormsApp3.Tests.TwoArgumentOperation
{
    [TestFixture]
    public class DivisionCalculatorTests
    {
        [TestCase(2, 2, 1)]
        [TestCase(3, 4, 0.75)]
        [TestCase(-3, -8, 0.375)]
        public void CalculateTest(double firstValue, double secondValue, double expected)
        {
            var calculator = new DivisionCalculator();
            var actualResult = calculator.Calculate(firstValue, secondValue);
            Assert.AreEqual(expected, actualResult);
        }
        [Test]
        public void CatchExceptions()
        {
            ITwoArgumentCalculator divisionCalculator = new DivisionCalculator();
            Assert.Throws<Exception>(() => divisionCalculator.Calculate(1, 0));
        }
    }
}