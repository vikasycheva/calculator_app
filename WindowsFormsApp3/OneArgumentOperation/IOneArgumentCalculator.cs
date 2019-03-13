namespace WindowsFormsApp3.OneArgumentOperation
{
    /// <summary>
    /// Interface class for one argument calculator
    /// </summary>
    public interface IOneArgumentCalculator
    {/// <summary>
     /// Interface method for One Argument Caclulator classes
     /// </summary>
     /// <param name="argument">real number</param>
     /// <returns>returns the result of desired operation</returns>
        double Calculate(double argument);
    }
}
