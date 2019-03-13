using System;
using WindowsFormsApp3.OneArgumentOperation;
using NUnit.Framework;

namespace WindowsFormsApp3.Tests.OneArgumentOperation
{
    [TestFixture]
    public class CosCalculatorTests
    {
        [TestCase(0, 1)]
        [TestCase(Math.PI, -1)]
        [TestCase(Math.PI / 2, 0)]
        public void CalculateTest(double firstValue, double expected)
        {
            var calculator = new CosCalculator();
            var actualResult = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, actualResult, 0.0001);
        }
    }
}