using System;

namespace WindowsFormsApp3.OneArgumentOperation
{
    /// <summary>
    /// class for calculating sine of argument
    /// </summary>
    public class SineCalculator : IOneArgumentCalculator
    {/// <summary>
     /// calculating sine of argument
     /// </summary>
     /// <param name="argument">any value in radians</param>
     /// <returns>returns sine of argument</returns>
        public double Calculate(double argument)
        {
            return Math.Sin(argument);
        }
    }
}
