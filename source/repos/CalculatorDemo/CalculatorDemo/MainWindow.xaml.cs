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

namespace CalculatorDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        double number1 = 0;
        double number2 = 0;
        string operation = "";

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, ExecutedRoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 1;
                // txtDisplay.Text = number1.ToString();
            }
            else
            {
                number2 = (number1 * 10) + 1;
                // txtDisplay.Text = number2.ToString();
            }
        }






        private void btn7_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 7;
                txtDisplay.Text = number1.ToString();
                // txtDisplay = number1;
            }
            else
            {
                number2 = (number1 * 10) + 7;
                txtDisplay.Text = number2.ToString();
            }

        }

        private void btn8_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 8;
                txtDisplay.Text = number1.ToString();
                // txtDisplay = number1;
            }
            else
            {
                number2 = (number1 * 10) + 7;
                txtDisplay.Text = number2.ToString();
            }
        }

        private void btn9_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 9;
                txtDisplay.Text = number1.ToString();
                // txtDisplay = number1;
            }
            else
            {
                number2 = (number1 * 10) + 7;
                txtDisplay.Text = number2.ToString();
            }
        }

        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 4;
                txtDisplay.Text = number1.ToString();
                // txtDisplay = number1;
            }
            else
            {
                number2 = (number1 * 10) + 7;
                txtDisplay.Text = number2.ToString();
            }
        }

        private void btn5_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 5;
                txtDisplay.Text = number1.ToString();
                // txtDisplay = number1;
            }
            else
            {
                number2 = (number1 * 10) + 7;
                txtDisplay.Text = number2.ToString();
            }
        }

        private void btn6_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 6;
                txtDisplay.Text = number1.ToString();
                // txtDisplay = number1;
            }
            else
            {
                number2 = (number1 * 10) + 7;
                txtDisplay.Text = number2.ToString();
            }
        }

        private void btn1_Click_1(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 1;
                txtDisplay.Text = number1.ToString();
                // txtDisplay = number1;
            }
            else
            {
                number2 = (number1 * 10) + 7;
                txtDisplay.Text = number2.ToString();
            }
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 2;
                txtDisplay.Text = number1.ToString();
                // txtDisplay = number1;
            }
            else
            {
                number2 = (number1 * 10) + 7;
                txtDisplay.Text = number2.ToString();
            }
        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 3;
                txtDisplay.Text = number1.ToString();
                // txtDisplay = number1;
            }
            else
            {
                number2 = (number1 * 10) + 7;
                txtDisplay.Text = number2.ToString();
            }
        }

        private void btn0_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 0;
                txtDisplay.Text = number1.ToString();
                // txtDisplay = number1;
            }
            else
            {
                number2 = (number1 * 10) + 7;
                txtDisplay.Text = number2.ToString();
            }
        }

        private void btnDot_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnPlus_Click(object sender, RoutedEventArgs e)
        {
            operation = "+";
            txtDisplay.Text = "0";
        }

        private void btnSub_Click(object sender, RoutedEventArgs e)
        {
            operation = "-";
            txtDisplay.Text = "0";
        }

        private void btnMul_Click(object sender, RoutedEventArgs e)
        {
            operation = "*";
            txtDisplay.Text = "0";
        }

        private void btnDiv_Click(object sender, RoutedEventArgs e)
        {
            operation = "/";
            txtDisplay.Text = "0";
        }

        private void btnEqual_Click(object sender, RoutedEventArgs e)
        {
            switch (operation)
            {
                case "+":
                    txtDisplay.Text = (number2 + number1).ToString();
                    break;
                case "-":
                    txtDisplay.Text = (number2 - number1).ToString();
                    break;
                case "*":
                    txtDisplay.Text = (number2 * number1).ToString();
                    break;
                case "/":
                    txtDisplay.Text = (number2 / number1).ToString();
                    break;
                case "":
                    txtDisplay.Text = (number2 + number1).ToString();
                    break;
            }



        }

        private void btnPlusMin_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 *= -1;
                txtDisplay.Text = number1.ToString();
            }
            else
            {
                number2 *= -1;
                txtDisplay.Text = number2.ToString();
            }

        }

        private void btnCE_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = 0;

            }
            else
            {
                number2 = 0;
            }
            txtDisplay.Text = "0";
        }

        private void btnC_Click(object sender, RoutedEventArgs e)
        {
            number1 = 0;
            number2 = 0;
            operation = "";
            txtDisplay.Text = "0";
        }

        private void btnBackspace_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 / 10);
                txtDisplay.Text = number1.ToString();
            }
            else
            {
                number1 = (number1 / 10);
                txtDisplay.Text = number1.ToString();
            }
        }
    }
}
