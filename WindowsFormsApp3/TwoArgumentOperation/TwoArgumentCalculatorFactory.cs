using System;

namespace WindowsFormsApp3.TwoArgumentOperation
{
    /// <summary>
    /// Fabric class for two argument calculator classes
    /// </summary>
    public static class TwoArgumentCalculatorFactory
    {
        /// <summary>
        /// creating object of desired two argument calculator classes
        /// </summary>
        /// <param name="operationName">name of the pressed button</param>
        /// <returns>returns new object of desired class</returns>
        public static ITwoArgumentCalculator CreateCalculator(string operationName)
        {
            switch (operationName)
            {
                case "addition":
                    return new AdditionCalculator();
                case "substraction":
                    return new SubstractionCalculator();
                case "multiplication":
                    return new MultiplicationCalculator();
                case "division":
                    return new DivisionCalculator();
                case "max":
                    return new MaximumOfCalculator();
                case "arithmetic":
                    return new AverageArithmeticCalculator();
                case "geometric":
                    return new AverageGeometricCalculator();
                case "min":
                    return new MinimumOfCalculator();
                case "remainder":
                    return new RemainderCalculator();
                case "integerDivision":
                    return new IntegerDivisionCalculator();
                default:
                    throw new ArgumentException("Неизвестная операция", "operationName");
            }
        }
    }
}
