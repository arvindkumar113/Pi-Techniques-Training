using System;
using System.Collections.Generic;
using System.Linq;                  
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Xml.Linq;

namespace DBLibrary
{
    public class UserDataStore
    {

        public void Connected()
        {
            UserData user = null;
            Console.WriteLine("Enter username");
            user.userName = Console.ReadLine();
            Console.WriteLine("Enter password");
            user.password = Console.ReadLine();

            bool result = ValidateUserCon(user);

            if (result)
            {
                Console.WriteLine("Valid User");
            }
            else
                Console.WriteLine("Invalid User");

        }

        public void DisConnected()
        {
            UserData user = null;
            Console.WriteLine("Enter username");
            user.userName = Console.ReadLine();
            Console.WriteLine("Enter password");
            user.password = Console.ReadLine();

            bool result = ValidateUserDisc(user);

            if (result)
            {
                Console.WriteLine("Valid User");
            }
            else
                Console.WriteLine("Invalid User");

        }


        public void Main(string[] args)
        {

            Console.WriteLine("----------Check Validity of User by Connected Way----------");
            Connected();

            Console.WriteLine("----------------Check Validity of user by Disconnected Way------");
            DisConnected();




        }


        public bool ValidateUserCon(UserData user)
        {
            SqlCommand command = null;
            SqlDataReader reader = null;
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["connstr"].ConnectionString);

            try
            {

                string sql = "select * from userdata where username=@user.userName and password =@user.password";
                command = new SqlCommand(sql, connection);

                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }

                string username = null;
                string password = null;
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    username = reader["userName"].ToString();
                    password = reader["password"].ToString();

                }
                if (username == @user.userName && password == user.password)
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
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }


        }

        //write a method which validate user
        //using disconnected architecture first populate dataset will full table data(UserData)
        //query - select* from userdata(no where clause)
        //once data is in DataSet filter dataset using select() method for username and password
        //if found return true else return false
        public bool ValidateUserDisc(UserData user)
        {


            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["connstr"].ConnectionString);


            try
            {

                string sql = "select * from userdata";

                SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
                DataSet ds = new DataSet();
                adapter.Fill(ds, "UserDataTable");

                //ds.Tables["emp"].Select(userName=@user.userName)

                DataRow[] dr = ds.Tables["UserDataTable"].Select($"USERNAME='{user.userName}' AND PASSWORD='{user.password}'");


                if (dr != null && dr.Length != 0)
                    return true;
                else
                    return false;


            }
            catch (Exception)
            {
                throw;
            }



        }
    }
}
