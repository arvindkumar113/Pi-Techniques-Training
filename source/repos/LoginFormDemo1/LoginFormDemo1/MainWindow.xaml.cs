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

namespace LoginFormDemo1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        int count = 0;
        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            string username = this.UserNameField.Text;
            string password = this.PasswordField.Password;
            if (username == "admin" && password == "123")
            {
                MessageBox.Show("Logged in Success");
                MainWindow mainWindow = new MainWindow();
                mainWindow.Show();
                this.Close();
            }
            else
            {
                count++;
                MessageBox.Show("Invalid username or password.", "Login failed");
            }
            if (count >= 3)
                this.Close();
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
