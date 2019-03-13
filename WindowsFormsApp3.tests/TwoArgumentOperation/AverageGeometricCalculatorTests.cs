using WindowsFormsApp3.TwoArgumentOperation;
using NUnit.Framework;

namespace WindowsFormsApp3.Tests.TwoArgumentOperation
{
    [TestFixture]
    public class AverageGeometricCalculatorTectCase
    {
        [TestCase(3, 3, 3)]
        [TestCase(4, 9, 6)]
        [TestCase(0, 1, 0)]
        public void CalculateTest(double firstValue, double secondValue, double expected)
        {
            var calculator = new AverageGeometricCalculator();
            var actualResult = calculator.Calculate(firstValue, secondValue);
            Assert.AreEqual(expected, actualResult);
        }
    }
}
