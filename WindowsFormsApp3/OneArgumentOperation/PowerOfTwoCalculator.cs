using System;

namespace WindowsFormsApp3.OneArgumentOperation
{
    /// <summary>
    /// class for calculating power of two
    /// </summary>
    public class PowerOfTwoCalculator : IOneArgumentCalculator
    {/// <summary>
     /// calculating 2^x
     /// </summary>
     /// <param name="argument">any real number</param>
     /// <returns>returns the result of 2^x</returns>
        public double Calculate(double argument)
        {
            return Math.Pow(2, argument);
        }
    }
}
