﻿using System;
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
using System.Windows.Shapes;

namespace WPF_INotify_Changed_Property
{
    /// <summary>
    /// Interaction logic for CommandDemo.xaml
    /// </summary>
    public partial class CommandDemo : Window
    {
        IncrementCounter blObj = new IncrementCounter();

        public CommandDemo()
        {
            InitializeComponent();
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Key==Key.F1)
            {
                blObj.Increment();
            }

        }

        private void Increment_Click(object sender, RoutedEventArgs e)
        {
            blObj.Increment();
            txtcount.Text = blObj.Counter.ToString();
        }
    }
}
