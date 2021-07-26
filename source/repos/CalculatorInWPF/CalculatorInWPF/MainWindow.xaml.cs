using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CalculatorInWPF
{
    
        /// <summary>
        /// Interaction logic for MainWindow.xaml
        /// </summary>

        public partial class MainWindow : Window
        {
            string input = "", operand1 = "", operand2 = "";
            char mathOperation;
            double result = 0, num1 = 0, num2 = 0, tempNegative = 0;

            public MainWindow()
            {
                InitializeComponent();

                //call numResult sometime in this program
            }

            private void ClearButtonClick(object sender, RoutedEventArgs e)
            {
                operand1 = "";
                operand2 = "";
                NumTextBox.Text = "";
                totalOperationTextBox.Text = "";
            }

            private void OperationStuff(char character)
            {
                mathOperation = character;
                operand1 = input;
                input = "";
            }

            private void AddOperation(object sender, RoutedEventArgs e)
            { OperationStuff('+'); }

            private void SubtractOperation(object sender, RoutedEventArgs e)
            { OperationStuff('-'); }

            private void DivideOperation(object sender, RoutedEventArgs e)
            { OperationStuff('/'); }

            private void MultiplyOperation(object sender, RoutedEventArgs e)
            { OperationStuff('*'); }

            private void EqualOperation(object sender, RoutedEventArgs e)
            {
                operand2 = input;


                //when you try to put in just a -8 as your first number and press =, it will not be able to parse
                if (!double.TryParse(operand1, out num1))
                {
                    MessageBox.Show("Could not parse operand1");
                    return;
                }
                if (!double.TryParse(operand2, out num2))
                {
                    MessageBox.Show("Could not parse operand2");
                    return;
                }

                NumTextBox.Text = "";
                input = "";
                operand1 = "";
                operand2 = "";

                /* How to use to match characters?
                switch (mathOperation)
                {}*/

                if (mathOperation == '+')
                {
                    result = num1 + num2;
                    totalOperationTextBox.Text = result.ToString();
                }
                else if (mathOperation == '-')
                {
                    result = num1 - num2;
                    totalOperationTextBox.Text = result.ToString();
                }
                else if (mathOperation == '/')
                {
                    if (num2 != 0)
                    {
                        result = num1 / num2;
                    }
                    else if (num2 == 0)
                    {
                        totalOperationTextBox.Text = "Cannot divide by zero";
                        NumTextBox.Text = "";
                        input = "";
                        operand1 = "";
                        operand2 = "";
                    }
                    /*
                    try
                    {
                        result = num1 / num2;
                    }
                    catch (DivideByZeroException)
                    {
                        totalOperationTextBox.Text = "Cant divide by zero";
                    }*/

                    totalOperationTextBox.Text = result.ToString();
                }
                else if (mathOperation == '*')
                {
                    result = num1 * num2;

                    totalOperationTextBox.Text = result.ToString();
                }
                else
                {
                    MessageBox.Show("No correct operation chosen!?");
                }

                NumTextBox.Text = "";
                input = "";
                operand1 = "";
                operand2 = "";
            }

            private void AddDecimal(object sender, RoutedEventArgs e)
            {
                NumTextBox.Text = "";
                input += '.';
                NumTextBox.Text = input;
            }

            //allows us to simply take whats been currently put in and make it negative
            private void MakeNegative(object sender, RoutedEventArgs e)
            {
                NumTextBox.Text = "";
                double.TryParse(input, out tempNegative);
                tempNegative *= -1;
                input = tempNegative.ToString();
                NumTextBox.Text = input;
            }

            //shortcut function to reduce # of lines. Does the digit selection adding to the current input
            private void AddDigitFunction(int digit)
            {
                NumTextBox.Text = "";
                input += digit;
                NumTextBox.Text = input;
            }

            /* Maybe have all of the buttons call one method that grabs their
            * text and send that to the function instead of all of these calls that take of space*/
            private void AddZero(object sender, RoutedEventArgs e)
            { AddDigitFunction(0); }
            private void AddOne(object sender, RoutedEventArgs e)
            { AddDigitFunction(1); }
            private void AddTwo(object sender, RoutedEventArgs e)
            { AddDigitFunction(2); }
            private void AddThree(object sender, RoutedEventArgs e)
            { AddDigitFunction(3); }
            private void AddFour(object sender, RoutedEventArgs e)
            { AddDigitFunction(4); }
            private void AddFive(object sender, RoutedEventArgs e)
            { AddDigitFunction(5); }
            private void AddSix(object sender, RoutedEventArgs e)
            { AddDigitFunction(6); }
            private void AddSeven(object sender, RoutedEventArgs e)
            { AddDigitFunction(7); }
            private void AddEight(object sender, RoutedEventArgs e)
            { AddDigitFunction(8); }
            private void AddNine(object sender, RoutedEventArgs e)
            { AddDigitFunction(9); }



        }
    
}
