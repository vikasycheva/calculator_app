namespace WindowsFormsApp3.TwoArgumentOperation
{
    /// <summary>
    /// class for addition of two nubmers
    /// </summary>
    public class AdditionCalculator : ITwoArgumentCalculator
    {/// <summary>
     /// calculating the result of addition of two numbers
     /// </summary>
     /// <param name="firstValue">first number</param>
     /// <param name="secondValue">second number</param>
     /// <returns>the result of addition</returns>
        public double Calculate(double firstValue, double secondValue)
        {
            return firstValue + secondValue;
        }
    }
}
