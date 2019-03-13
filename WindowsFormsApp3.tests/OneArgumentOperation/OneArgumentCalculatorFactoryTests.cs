using System;
using WindowsFormsApp3.OneArgumentOperation;
using NUnit.Framework;

namespace WindowsFormsApp3.Tests.OneArgumentOperation
{
    [TestFixture]
    public class OneArgumentFactoryTests
    {
        [TestCase("sin", typeof(SineCalculator))]
        [TestCase("cos", typeof(CosCalculator))]
        [TestCase("naturalLogarithm", typeof(NaturalLogarithmCalculator))]
        [TestCase("logTwo", typeof(LogarithmForBaseTwoCalculator))]
        [TestCase("logTen", typeof(LogarithmForBaseTenCalculator))]
        [TestCase("sqr", typeof(SquareCalculator))]
        [TestCase("twoPowerOf", typeof(PowerOfTwoCalculator))]
        [TestCase("tenPowerOf", typeof(PowerOfTenCalculator))]
        [TestCase("negative", typeof(NegativeArgumentCalculator))]

        [TestCase("arccos", typeof(ArccosCalculator))]
        [TestCase("arcsin", typeof(ArcsinCalculator))]
        [TestCase("arctan", typeof(ArctanCalculator))]
        [TestCase("ctan", typeof(CtanCalculator))]
        [TestCase("exp", typeof(ExpCalculator))]
        [TestCase("hyperbola", typeof(HyperbolaCalculator))]
        [TestCase("tan", typeof(TanCalculator))]

        public void CalculateTest(string name, Type type)
        {
            var calculator = OneArgumentCalculatorFactory.CreateCalculator(name);

            Assert.IsInstanceOf(type, calculator);
        }
    }

}
