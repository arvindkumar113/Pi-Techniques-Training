using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserValidationLibrary
{
    public class UserDataStore
    {
        SqlConnection connection = new SqlConnection();
        SqlCommand command = new SqlCommand();
        SqlDataAdapter adapter = new SqlDataAdapter();
        //SqlDataReader reader;
        DataSet ds;

        public UserDataStore(string connectionString)
        {
            //assigining connection to the path of database and tables -- for both connected and disconnected
            connection = new SqlConnection(connectionString);

            //populating data userdata table data into adapter
            adapter = new SqlDataAdapter("select * from userdata", connection);

            //creating dataset ds for storing userdata table into it for disconnected archit.
            ds = new DataSet();

            //storing/filling userdata table into ds with he help of adapter
            adapter.Fill(ds, "userdatatable");

        }

        public bool ValidateUser_Datast_Disconnected(UserData user)
        {
            //searching for the object passed "user's " information(UserName and Password) matches
            //with anyone in the userdatatable
            //DataRow[] rows = ds.Tables["userdatatable"].Select($"username='{user.UserName}' and password='{user.Password}'");

            //if (rows.Length == 1)
            //    return true;
            //else
            //    return false;

            DataRow[] rows = ds.Tables["userdatatable"].Select($"username='{user.UserName}' and password = '{user.Password}'");


            if (rows.Length == 1)
            {
                return true;
            }
            else
                return false;

        }

        public bool ValidateUser_Connected(UserData user)
        {
            try
            {
                //SQL command to validate user and storing in string so that I can pass it with command
                string sql = "select count(username) from userdata where username=@uname and password=@pwd";

                //making command passing sql query and connection string
                command = new SqlCommand(sql, connection);

                //in sql command we need two parameter uname(i.e username) and pwd(i.e. password) 
                //so giving two parameter
                command.Parameters.AddWithValue("uname", user.UserName);//passing parameter username
                command.Parameters.AddWithValue("pwd", user.Password);//passing paramater password

                //checking that connection is open or not. If not open then open it
                if(connection.State==ConnectionState.Closed)
                {
                    connection.Open();
                }

                //executing command if user is found with correct credentials then count=1 else count=0
                int countUserName = (int) command.ExecuteScalar();

                //three types of execute command
                //ExecuteScalar() =>when query return only one scalar value
                //ExecuteNonQuery => when we need insert, update, delete and returns number of rows affected
                //ExecuteReader => used when select or stored procedure are executed and return set of row(s) from the DB

                if (countUserName == 1)
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
                if(connection.State==ConnectionState.Open)
                {
                    connection.Close();
                }
            }

        }





    }
}
