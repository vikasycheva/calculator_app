using System;
using System.Windows.Forms;
using WindowsFormsApp3.OneArgumentOperation;
using WindowsFormsApp3.TwoArgumentOperation;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// method for processing button clicks for two argument operations
        /// </summary>
        private void OpertionForTwoArgument(object sender, EventArgs e)
        {
            try
            {
                double firstNumber = Convert.ToDouble(firstArgument.Text);
                double secondNumber = Convert.ToDouble(secondArgument.Text);
                string operationName = ((Button) sender).Name;
                ITwoArgumentCalculator calculator = TwoArgumentCalculatorFactory.CreateCalculator(operationName);
                double resultValue = calculator.Calculate(firstNumber, secondNumber);
                result.Text = Convert.ToString(resultValue);
            }
            catch (FormatException exc)
            {
                result.Text = "Введите число";
            }
            catch (Exception exc)
            {
                result.Text = exc.Message;
            }
        }
        /// <summary>
        /// method for processing button clicks for one argument operations
        /// </summary>
        private void OpertionForOneArgument(object sender, EventArgs e)
        {
            try
            {
                double argument = Convert.ToDouble(firstArgument.Text);
                string operationName = ((Button) sender).Name;
                IOneArgumentCalculator calculator = OneArgumentCalculatorFactory.CreateCalculator(operationName);
                double resultValue = calculator.Calculate(argument);
                result.Text = Convert.ToString(resultValue);
            }
            catch (FormatException exc)
            {
                result.Text = "Введите число";
            }
            catch (Exception exc)
            {
                result.Text = exc.Message;
            }
        }
    }
}
