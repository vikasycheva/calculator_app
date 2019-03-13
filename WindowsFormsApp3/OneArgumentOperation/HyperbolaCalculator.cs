using System;

namespace WindowsFormsApp3.OneArgumentOperation
{
    /// <summary>
    /// Class for calculating 1/x values
    /// </summary>
    public class HyperbolaCalculator : IOneArgumentCalculator
    {
        /// <summary>
        /// calculating 1/x values
        /// </summary>
        /// <param name="argument">any real number value, excluding 0</param>
        /// <returns>returns value of 1/x operation</returns>
        public double Calculate(double argument)
        {
            if (argument == 0)
            {
                throw new Exception("Деление на 0");
            }
            return 1 / argument;
        }
    }
}
