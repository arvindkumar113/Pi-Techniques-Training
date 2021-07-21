using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexers_In_CSharp
{
    public class User
    {
        //decraring an array of strings
        private string[] userName = new string[5];

        public string this[int i]
        {
            get { return userName[i]; }
            set { userName[i] = value; }
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            //assigining username using index
            User userList = new User();
            userList[0] = "Arvind Kumar";
            userList[1] = "Shubham Kumar";
            userList[2] = "Pranay";
            userList[3] = "Manthan Charausia";

            Console.WriteLine("Printing User class object using index");
            for(int i=0; i<4;i++)
            {
                Console.WriteLine(userList[i]);
            }
            Console.ReadKey();
        }
    }
}
