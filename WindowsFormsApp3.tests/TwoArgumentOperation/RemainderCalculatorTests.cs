using System;
using WindowsFormsApp3.TwoArgumentOperation;
using NUnit.Framework;

namespace WindowsFormsApp3.Tests.TwoArgumentOperation
{
    [TestFixture]
    public class RemainderCalculatorTests
    {
        [TestCase(2, 2, 0)]
        [TestCase(3, 4, 3)]
        [TestCase(-3, -8, -3)]
        public void CalculateTest(double firstValue, double secondValue, double expected)
        {
            var calculator = new RemainderCalculator();
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