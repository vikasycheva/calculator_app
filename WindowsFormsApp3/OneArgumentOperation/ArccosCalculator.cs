using System;

namespace WindowsFormsApp3.OneArgumentOperation
{
    /// <summary>
    /// Class for calculating arccos of argument
    /// </summary>
    public class ArccosCalculator : IOneArgumentCalculator
    {
        /// <summary>
        /// Calculating arccos of argument
        /// </summary>
        /// <param name="argument">Value in radians</param>
        /// <returns>returns the angle of cosine </returns>
        public double Calculate(double argument)
        {
            if (argument > 1 || argument < -1)
            {
                throw new Exception("Недопустимый аргумент");
            }
            return Math.Acos(argument);
        }
    }
}
