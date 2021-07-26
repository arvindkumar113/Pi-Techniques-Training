using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;


using DataValidationLibrary;



namespace UserValidationApp
{
    public class Program
    {
        UserDataStore userdatastore;

        public Program()
        {
            userdatastore = new UserDataStore(ConfigurationManager.ConnectionStrings["connstr"].ConnectionString);
        }

        void Display_VaidateUser_Connected()
        {
            //taking input from user
            Console.WriteLine("Enter username");
            string username = Console.ReadLine();
            Console.WriteLine("Enter password");
            string password = Console.ReadLine();

            //put username and password in object and pass to the VaidateUser_Connected() function
            UserData userData = new UserData();
            userData.UserName = username;
            userData.Password = password;

            bool result = userdatastore.VaidateUser_Connected(userData);

            if (result)
                Console.WriteLine("Valid User");
            else
                Console.WriteLine("Invalid User");


        }

        //method for calling ValidateUser_DataSet
        public void Display_ValidateUser_DataSet()
        {
            //taking input from user
            Console.WriteLine("Enter username");
            string username = Console.ReadLine();
            Console.WriteLine("Enter password");
            string password = Console.ReadLine();

            //put username and password in object and pass to the VaidateUser_Connected() function
            UserData userData = new UserData();
            userData.UserName = username;
            userData.Password = password;

            bool result = userdatastore.ValidateUser_DataSet(userData);

            if (result)
                Console.WriteLine("Valid User");
            else
                Console.WriteLine("Invalid User");
        }


        static void Main(string[] args)
        {
            Console.WriteLine("-----------Connected User Validaation Demo--------------");
            Program program = new Program();

            program.Display_VaidateUser_Connected();


            Console.WriteLine("-----------Disconnected User Validaation Demo--------------");
            program.Display_ValidateUser_DataSet();


            Console.ReadLine();
        }
    }
}
