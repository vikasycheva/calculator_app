namespace WindowsFormsApp3.TwoArgumentOperation
{
    /// <summary>
    /// class for calculating minimum of two numbers
    /// </summary>
    public class MinimumOfCalculator : ITwoArgumentCalculator
    {/// <summary>
     /// chosing minimum value of two numbers
     /// </summary>
     /// <param name="firstValue">first number</param>
     /// <param name="secondValue">second number</param>
     /// <returns>return the maximum of two numbers</returns>
        public double Calculate(double firstValue, double secondValue)
        {
            if (firstValue < secondValue)
                return firstValue;
            else
                return secondValue;
        }
    }
}
