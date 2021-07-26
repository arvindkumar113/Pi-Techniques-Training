using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Library_Management_Project
{
    public partial class login : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;I
nitial Catalog=Library_Management_System;Integrated Security=True;Connect Timeout=30;Encrypt=False;
TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");


        public login()
        {
            InitializeComponent();
        }
    }
}
