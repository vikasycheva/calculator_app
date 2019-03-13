using System;
using WindowsFormsApp3.TwoArgumentOperation;
using NUnit.Framework;

namespace WindowsFormsApp3.Tests.TwoArgumentOperation
{
    [TestFixture]
    public class TwoArgumentFactoryTests
    {
        [TestCase("addition", typeof(AdditionCalculator))]
        [TestCase("substraction", typeof(SubstractionCalculator))]
        [TestCase("multiplication", typeof(MultiplicationCalculator))]
        [TestCase("division", typeof(DivisionCalculator))]
        [TestCase("max", typeof(MaximumOfCalculator))]
        [TestCase("arithmetic", typeof(AverageArithmeticCalculator))]
        [TestCase("geometric", typeof(AverageGeometricCalculator))]
        [TestCase("min", typeof(MinimumOfCalculator))]
        [TestCase("remainder",typeof(RemainderCalculator))]
        [TestCase("integerDivision",typeof(IntegerDivisionCalculator))]
        public void CalculateTest(string name, Type type)
        {
            var calculator = TwoArgumentCalculatorFactory.CreateCalculator(name);
            Assert.IsInstanceOf(type, calculator);
        }
    }

}
