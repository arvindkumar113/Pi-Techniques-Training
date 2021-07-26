﻿
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
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

namespace WpfAppDemo
{
  
public partial class CountryStateComboBox : Window
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["connstr"].ConnectionString);
        DataSet ds = null;
        public CountryStateComboBox()
        {
            InitializeComponent();
            BindComboBox(cmbCountry);
        }

        public void BindComboBox(ComboBox combo)
        {

            SqlDataAdapter da = new SqlDataAdapter("Select * from Country", conn);
            ds = new DataSet();
            da.Fill(ds, "Country");
            combo.ItemsSource = ds.Tables["Country"].DefaultView;
            combo.DisplayMemberPath = ds.Tables["Country"].Columns["CON_NAME"].ToString();
            combo.SelectedValuePath = ds.Tables["Country"].Columns["CON_ID"].ToString();
        }
        private void cmbCountry_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int index = int.Parse(cmbCountry.SelectedValue.ToString());
            string express = $"CON_ID='{index}'";
            DataRow[] rows = ds.Tables["Country"].Select(express);

            txtCcapital.Text = rows[0]["CAPITAL"].ToString();

            //BitmapImage bitmap = new BitmapImage();
            //bitmap.BeginInit();
            //bitmap.UriSource = new Uri(rows[0]["FLAG"].ToString());
            //bitmap.EndInit();
            //Cflag.Source = bitmap;

            object selected = cmbCountry.SelectedItem;
            DataRow row = ((DataRowView)selected).Row;

            // Get the raw bytes of the image
            byte[] photoSource = (byte[])row["FLAG"];

            // Create the bitmap object
            // NOTE: This is *not* a GDI+ Bitmap object
            BitmapImage bitmap = new BitmapImage();
            MemoryStream strm = new MemoryStream();

            int offset = 78;
            strm.Write(photoSource, offset, photoSource.Length - offset);

            // Read the image into the bitmap object
            bitmap.BeginInit();
            bitmap.StreamSource = strm;
            bitmap.EndInit();

            // Set the Image with the Bitmap
            Cflag.Source = bitmap;



            //State binding
            SqlDataAdapter da = new SqlDataAdapter("Select * from State", conn);
            da.Fill(ds, "State");
            express = $"CON_ID='{index}'";
            rows = ds.Tables["State"].Select(express);
            cmbState.ItemsSource = rows.ToString();
            cmbState.DisplayMemberPath = rows[0]["STATE_NAME"].ToString();
            cmbState.SelectedValuePath = rows[0]["STATE_NAME"].ToString();


        }

        private void cmbState_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}