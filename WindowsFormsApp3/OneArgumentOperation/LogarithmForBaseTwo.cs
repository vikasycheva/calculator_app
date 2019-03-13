using System;

namespace WindowsFormsApp3.OneArgumentOperation
{
    /// <summary>
    /// Class for calculating logarithm for base of two
    /// </summary>
    public class LogarithmForBaseTwoCalculator : IOneArgumentCalculator
    {/// <summary>
     /// calculating logarithm for base of two
     /// </summary>
     /// <param name="argument">any positive real number</param>
     /// <returns>returns logarithm for base of two</returns>
        public double Calculate(double argument)
        {
            if (argument <= 0)
                throw new Exception("Неправильный аргумент");
            return Math.Log(argument, 2);
        }
    }
}
