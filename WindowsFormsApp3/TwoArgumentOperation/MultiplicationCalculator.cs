namespace WindowsFormsApp3.TwoArgumentOperation
{
    /// <summary>
    /// class for calculating the result of multiplication between two numbers
    /// </summary>
    public class MultiplicationCalculator : ITwoArgumentCalculator
    {/// <summary>
     /// multiplicating two numbers
     /// </summary>
     /// <param name="firstValue">first number</param>
     /// <param name="secondValue">second number</param>
     /// <returns>returns the result of multiplication</returns>
        public double Calculate(double firstValue, double secondValue)
        {
            return firstValue * secondValue;
        }
    }


}
