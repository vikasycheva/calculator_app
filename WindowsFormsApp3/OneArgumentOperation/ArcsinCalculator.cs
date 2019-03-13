using System;

namespace WindowsFormsApp3.OneArgumentOperation
{
    /// <summary>
    /// Class for calculating arcsine of argument
    /// </summary>
    public class ArcsinCalculator : IOneArgumentCalculator
    {/// <summary>
     /// Calculating arcsine of argument
     /// </summary>
     /// <param name="argument">Value in radians</param>
     /// <returns>returns the angle of sine</returns>
        public double Calculate(double argument)
        {
            if (argument > 1 || argument < -1)
            {
                throw new Exception("Недопустимый аргумент");
            }
            return Math.Asin(argument);
        }
    }

}
