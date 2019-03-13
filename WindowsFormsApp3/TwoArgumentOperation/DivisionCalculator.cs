using System;

namespace WindowsFormsApp3.TwoArgumentOperation
{
    /// <summary>
    /// class for calculating the result of division between two numbers
    /// </summary>
    public class DivisionCalculator : ITwoArgumentCalculator
    {/// <summary>
     /// calculating the result of division between two numbers
     /// </summary>
     /// <param name="firstValue">dividend number</param>
     /// <param name="secondValue">divider number</param>
     /// <returns></returns>
        public double Calculate(double firstValue, double secondValue)
        {
            if (secondValue == 0)
            {
                throw new Exception("Деление на 0");
            }
            return firstValue / secondValue;
        }
    }
}
