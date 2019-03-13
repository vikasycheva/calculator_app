using System;

namespace WindowsFormsApp3.OneArgumentOperation
{
    /// <summary>
    /// Class for calculating logarithm for base of 10
    /// </summary>
    public class LogarithmForBaseTenCalculator : IOneArgumentCalculator
    {/// <summary>
     /// calculating logarithm for base of 10
     /// </summary>
     /// <param name="argument">any positive real number</param>
     /// <returns>returns logarithm for base of 10</returns>
        public double Calculate(double argument)
        {
            if (argument <= 0)
                throw new Exception("Неправильный аргумент");
            return Math.Log10(argument);
        }
    }
}
