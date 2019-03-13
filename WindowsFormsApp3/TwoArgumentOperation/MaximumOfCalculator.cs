namespace WindowsFormsApp3.TwoArgumentOperation
{
    /// <summary>
    /// class for calculating maximum of two numbers
    /// </summary>
    public class MaximumOfCalculator : ITwoArgumentCalculator
    {/// <summary>
     /// chosing maximum value between two numbers
     /// </summary>
     /// <param name="firstValue">first number</param>
     /// <param name="secondValue">second number</param>
     /// <returns>maximum value between two number</returns>
        public double Calculate(double firstValue, double secondValue)
        {
            if (firstValue > secondValue)
                return firstValue;
            else
                return secondValue;
        }
    }
}
