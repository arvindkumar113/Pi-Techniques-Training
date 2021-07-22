﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity;
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

namespace WPFAssignment3Of5
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        NorthwindEntities db;
        ObservableCollection<Product> productCollection;
        public MainWindow()
        {
            InitializeComponent();
            db = new NorthwindEntities();
        }

        private void mainGrid_Loaded(object sender, RoutedEventArgs e)
        {
            productCollection = new ObservableCollection<Product>(db.Products);

            lstItems.DataContext = productCollection;
        }

        private void lstItems_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
