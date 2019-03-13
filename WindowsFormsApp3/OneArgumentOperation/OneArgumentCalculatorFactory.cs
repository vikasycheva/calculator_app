using System;

namespace WindowsFormsApp3.OneArgumentOperation
{
    /// <summary>
    /// factory class for creating desired classes depending on chosen operations
    /// </summary>
    public class OneArgumentCalculatorFactory
    {/// <summary>
     /// method for creating examples of one argument calculator classes
     /// </summary>
     /// <param name="operationName">name of the button pressed</param>
     /// <returns>return object of desired class</returns>
        public static IOneArgumentCalculator CreateCalculator(string operationName)
        {
            switch (operationName)
            {
                case "sin":
                    return new SineCalculator();
                case "cos":
                    return new CosCalculator();
                case "naturalLogarithm":
                    return new NaturalLogarithmCalculator();
                case "logTwo":
                    return new LogarithmForBaseTwoCalculator();
                case "logTen":
                    return new LogarithmForBaseTenCalculator();
                case "sqr":
                    return new SquareCalculator();
                case "twoPowerOf":
                    return new PowerOfTwoCalculator();
                case "tenPowerOf":
                    return new PowerOfTenCalculator();
                case "negative":
                    return new NegativeArgumentCalculator();
                case "tan":
                    return new TanCalculator();
                case "arcsin":
                    return new ArcsinCalculator();
                case "arccos":
                    return new ArccosCalculator();
                case "ctan":
                    return new CtanCalculator();
                case "arctan":
                    return new ArctanCalculator();
                case "hyperbola":
                    return new HyperbolaCalculator();
                case "exp":
                    return new ExpCalculator();
                default:
                    throw new ArgumentException("Неизвестная операция", "operationName");
            }
        }
    }
}
