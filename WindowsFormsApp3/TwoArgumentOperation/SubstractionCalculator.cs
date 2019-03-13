namespace WindowsFormsApp3.TwoArgumentOperation
{
    /// <summary>
    /// class for calclulating the result of substraction between two numbers
    /// </summary>
    public class SubstractionCalculator : ITwoArgumentCalculator
    {/// <summary>
     /// calculating the result of substraction between two numbers
     /// </summary>
     /// <param name="firstValue">first number</param>
     /// <param name="secondValue">second number</param>
     /// <returns>returns the result of substraction</returns>
        public double Calculate(double firstValue, double secondValue)
        {
            return firstValue - secondValue;
        }
    }
}
