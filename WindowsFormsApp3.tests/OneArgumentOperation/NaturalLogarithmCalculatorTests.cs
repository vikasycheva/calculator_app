using System;
using WindowsFormsApp3.OneArgumentOperation;
using NUnit.Framework;

namespace WindowsFormsApp3.Tests.OneArgumentOperation
{
    [TestFixture]
    public class NaturalLogarithmCalculatorTests
    {
        [TestCase(1, 0)]
        [TestCase(3, 1.0986)]
        [TestCase(7, 1.9459)]
        public void CalculateTest(double firstValue, double expected)
        {
            var calculator = new NaturalLogarithmCalculator();
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
