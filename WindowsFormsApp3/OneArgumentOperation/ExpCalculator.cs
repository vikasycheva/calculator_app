using System;

namespace WindowsFormsApp3.OneArgumentOperation
{
    /// <summary>
    /// Class for calculating exponent of argument
    /// </summary>
    public class ExpCalculator : IOneArgumentCalculator
    {
        /// <summary>
        /// calculating exponent of argument
        /// </summary>
        /// <param name="argument">any real number value</param>
        /// <returns>returns value of exponent function</returns>
        public double Calculate(double argument)
        {
            return Math.Exp(argument);
        }
    }
}
