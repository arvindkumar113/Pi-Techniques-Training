using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

using System.Configuration;
using System.Xml.Linq;

namespace DatabaseApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Connected Architecture");
            ConnectedData();

            Console.WriteLine("Disconnected Architecture");
            Disconnected();
            Console.ReadLine();
        }


        //Connected Way example
        static void ConnectedData()
        {
            //SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["connstr"].ConnectionString);

            //string sql = "select * from emp";

            //SqlCommand command = new SqlCommand(sql, connection);


            //try
            //{
            //    if (connection.State == ConnectionState.Closed)
            //        connection.Open();

            //    SqlDataReader reader = command.ExecuteReader();

            //    while(reader.Read())
            //    {
            //        Console.WriteLine($"Emp Name : {reader["ename"]} \t Salary : {reader["sal"]} ");
            //    }

            //}
            //catch(Exception)
            //{
            //    throw;
            //}
            //finally
            //{
            //    if (connection.State == ConnectionState.Open)
            //        connection.Close();
            //}



        }



        //disconnected example
        static void Disconnected()
        {
            //SqlConnection connection = new SqlConnection(@" server= (localdb)\MSSQLLocalDB; database= training;" +
            //   " integrated security = true ;");
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["connstr"].ConnectionString);

            string sql = "select * from dept";

            SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "dept");

            foreach (DataRow row in ds.Tables["dept"].Rows)
            {
                Console.WriteLine($"Dept No : {row["deptno"]} \t Dept Name : {row["dname"]} \t Location : {row["Loc"]}");
            }

        }
    }
}
