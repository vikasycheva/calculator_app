using System;
using WindowsFormsApp3.OneArgumentOperation;
using NUnit.Framework;

namespace WindowsFormsApp3.Tests.OneArgumentOperation
{
    [TestFixture]
    public class CtanCalculatorTests
    {
        [TestCase(1, 0.64)]
        [TestCase(0.5, 1.83)]
        [TestCase(-1, -0.64)]
        public void CalculateTest(double firstValue, double expected)
        {
            var calculator = new CtanCalculator();
            var actualResult = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, actualResult, 0.01);
        }

        [TestCase(0)]
        [TestCase(2*Math.PI)]
        [TestCase(Math.PI)]
        public void CatchExceptions(double argument)
        {
            var calculator = new CtanCalculator();
            Assert.Throws<Exception>(() => calculator.Calculate(argument));
        }
    }
}
