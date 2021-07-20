
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace DataValidationLibrary
{
    public class UserDataStore
    {
        SqlConnection connection;
        SqlCommand command;
        SqlDataReader reader;
        SqlDataAdapter adapter;
        DataSet ds;


        public UserDataStore(string connectionString)
        {
            connection = new SqlConnection(connectionString);

            //populate userdata data into dataset
            adapter = new SqlDataAdapter("select * from userdata", connection);
            ds = new DataSet();
            adapter.Fill(ds, "userdata");

        }

        //method to validate user from dataset
        public bool ValidateUser_DataSet(UserData user)
        {
            DataRow[] rows = ds.Tables["userdata"].Select($"username='{user.UserName}' and password = '{user.Password}'");


            if (rows.Length == 1)
            {
                return true;
            }
            else
                return false;
        }


        public bool VaidateUser_Connected(UserData userData)
        {
            try
            {
                string sql = "select count(username) from userdata where username=@uname and password=@pwd";
                command = new SqlCommand(sql, connection);

                command.Parameters.AddWithValue("uname", userData.UserName);
                command.Parameters.AddWithValue("pwd", userData.Password);

                if(connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }

                int count = (int) command.ExecuteScalar();

                if (count == 1)
                    return true;
                else
                    return false;

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if(connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }

            }

        }





    }
}
