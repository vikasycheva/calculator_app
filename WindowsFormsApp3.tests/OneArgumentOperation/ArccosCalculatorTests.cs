using System;
using WindowsFormsApp3.OneArgumentOperation;
using NUnit.Framework;

namespace WindowsFormsApp3.Tests.OneArgumentOperation
{
    [TestFixture]
    public class ArccosCalculatorTests
    {
        [TestCase(1, 0)]
        [TestCase(0.5, 1.04)]
        [TestCase(-1, Math.PI)]
        public void CalculateTest(double firstValue, double expected)
        {
            var calculator = new ArccosCalculator();
            var actualResult = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, actualResult, 0.01);
        }

        [TestCase(2)]
        [TestCase(-2)]
        public void CatchExceptions(double argument)
        {
            var calculator = new ArccosCalculator();
            Assert.Throws<Exception>(() => calculator.Calculate(argument));
        }
    }
}
