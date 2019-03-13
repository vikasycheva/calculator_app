using System;
using WindowsFormsApp3.OneArgumentOperation;
using NUnit.Framework;

namespace WindowsFormsApp3.Tests.OneArgumentOperation
{
    [TestFixture]
    public class ArcsinCalculatorTests
    {
        [TestCase(1, Math.PI/2)]
        [TestCase(0.5, 0.523)]
        [TestCase(-1, -Math.PI/2)]
        public void CalculateTest(double firstValue, double expected)
        {
            var calculator = new ArcsinCalculator();
            var actualResult = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, actualResult, 0.01);
        }

        [TestCase(2)]
        [TestCase(-2)]
        public void CatchExceptions(double argument)
        {
            var calculator = new ArcsinCalculator();
            Assert.Throws<Exception>(() => calculator.Calculate(argument));
        }
    }
}
