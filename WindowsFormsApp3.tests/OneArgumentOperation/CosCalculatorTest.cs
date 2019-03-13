using System;
using WindowsFormsApp3.OneArgumentOperation;
using NUnit.Framework;

namespace WindowsFormsApp3.Tests.OneArgumentOperation
{
    [TestFixture]
    public class CosnCalculatorTests
    {
        [Test]
        public void CalculateTest()
        {
            IOneArgumentCalculator cosCalculator = new CosCalculator();
            double actualResult = cosCalculator.Calculate(Math.PI);
            double estimatedResult = -1;
            Assert.AreEqual(estimatedResult, actualResult);
        }
    }
}
