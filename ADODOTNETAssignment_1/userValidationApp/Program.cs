using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserValidationLibrary;

namespace userValidationApp
{
    

    public class Program
    {
        UserDataStore userdatastore;
        public Program()
        {
            userdatastore = new UserDataStore(ConfigurationManager.ConnectionStrings["connstr"].ConnectionString);
        }

        //validation of user using ValidateUser_Datast_Disconnected function i.e. disconnected arch
        public void ValidateUser_DisconnectedArchitecture()
        {
            UserData user = new UserData();
            Console.WriteLine("Enter User Name");
            user.UserName = Console.ReadLine();
            Console.WriteLine("Enter password");
            user.Password = Console.ReadLine();

            if (userdatastore.ValidateUser_Datast_Disconnected(user) == true)
            {
                Console.WriteLine("Valid User\n");
            }
            else
            {
                Console.WriteLine("Invalid Username or Password");
            }
        }

        //validation of user using ValidateUser_Connected function in connected architecture
        public void ValidateUser_ConnectedArchitecture()
        {
            UserData user = new UserData();
            Console.WriteLine("Enter User Name");
            user.UserName = Console.ReadLine();
            Console.WriteLine("Enter password");
            user.Password = Console.ReadLine();

            if(userdatastore.ValidateUser_Connected(user) ==true)
            {
                Console.WriteLine("Valid User\n");
            }
            else
            {
                Console.WriteLine("Invalid Username or Password");
            }

        }

        static void Main(string[] args)
        {
            Program program = new Program();
            //checking user validation using connected architecture
            Console.WriteLine("User Validation using the conneted architecture");
            program.ValidateUser_ConnectedArchitecture();

            //checking user validation using disconnected architecture
            Console.WriteLine("User Validation using Disconnected architecture");
            program.ValidateUser_DisconnectedArchitecture();
        }
    }
}
