using System;

namespace WindowsFormsApp3.OneArgumentOperation
{
    /// <summary>
    /// Class for calculating cosine of argument
    /// </summary>
    public class CosCalculator : IOneArgumentCalculator
    {
        /// <summary>
        /// calculating cosine of argument
        /// </summary>
        /// <param name="argument">any value in radians</param>
        /// <returns>returns the result of cosine operation</returns>
        public double Calculate(double argument)
        {
            return Math.Cos(argument);
        }
    }
}
