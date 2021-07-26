using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordStrengthChecking
{
    class Program
    {


        static void Main(string[] args)
        {
            int initializer = 1;

            while (initializer != 0)
            {
                Console.WriteLine("ENter 1 for again Checking");
                Console.WriteLine("Enter 0 to exit");
                initializer = int.Parse(Console.ReadLine());

                switch (initializer)
                {
                    case 1:
                        {
                            Console.WriteLine("Enter password");
                            string password = Console.ReadLine();
                            
                                //Console.WriteLine("Valid Password");
                                if ((password.Length > 6 || password.Length < 16) && password.Any(char.IsLower) == true && password.Any(char.IsUpper) == true)
                                    Console.WriteLine("Strong password");
                            
                           
                            break;
                        }
                    default:
                        {
                            break;
                        }
                }

            }

        }

    }
    }

