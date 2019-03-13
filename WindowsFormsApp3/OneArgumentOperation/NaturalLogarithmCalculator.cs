using System;

namespace WindowsFormsApp3.OneArgumentOperation
{
    /// <summary>
    /// class for calculating natural logarithm of argument
    /// </summary>
    public class NaturalLogarithmCalculator : IOneArgumentCalculator
    {/// <summary>
     /// calculating natural logarithm of argument
     /// </summary>
     /// <param name="argument">any positive real number</param>
     /// <returns>natural logarithm of argument</returns>
        public double Calculate(double argument)
        {
            if (argument <= 0)
                throw new Exception("Неправильный аргумент");
            return Math.Log(argument);
        }
    }
}
