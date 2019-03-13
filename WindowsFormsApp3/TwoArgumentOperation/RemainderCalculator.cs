using System;

namespace WindowsFormsApp3.TwoArgumentOperation
{
    /// <summary>
    /// class for calculating the remainder of division between two numbers
    /// </summary>
    public class RemainderCalculator : ITwoArgumentCalculator
    {/// <summary>
     /// calculating the remainder of division between two numbers
     /// </summary>
     /// <param name="firstValue">dividend</param>
     /// <param name="secondValue">divider</param>
     /// <returns>remainder of division</returns>
        public double Calculate(double firstValue, double secondValue)
        {
            if (secondValue == 0)
            {
                throw new Exception("Деление на 0");
            }
            return firstValue % secondValue;
        }
    }
}
