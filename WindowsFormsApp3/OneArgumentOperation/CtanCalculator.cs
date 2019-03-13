using System;

namespace WindowsFormsApp3.OneArgumentOperation
{
    /// <summary>
    /// Class for calculating cotan of argument
    /// </summary>
    public class CtanCalculator : IOneArgumentCalculator
    {/// <summary>
     /// calculating cotan of argument
     /// </summary>
     /// <param name="argument">value in radians</param>
     /// <returns>returns the result cotan operation</returns>
        public double Calculate(double argument)
        {
            if (argument % Math.PI == 0)
            {
                throw new Exception("Недопустимый аргумент");
            }
            return 1 / Math.Tan(argument);
        }
    }
}
