using System;
using WindowsFormsApp3.OneArgumentOperation;
using NUnit.Framework;

namespace WindowsFormsApp3.Tests.OneArgumentOperation
{
   [TestFixture]
   public class LogarithmForBaseTenCalculatorTests
    {
        [TestCase(1, 0)]
        [TestCase(1000, 3)]
        [TestCase(8, 0.9031)]
        public void CalculateTest(double firstValue, double expected)
        {
            var calculator = new LogarithmForBaseTenCalculator();
            var actualResult = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, actualResult, 0.0001);
        }
        [Test]
        public void CathExceptions()
        {
            var calculator = new NaturalLogarithmCalculator();
            Assert.Throws<Exception>(() => calculator.Calculate(0));
        }
    }
}
