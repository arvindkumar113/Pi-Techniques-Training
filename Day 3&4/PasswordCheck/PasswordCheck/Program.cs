using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordCheck
{




    class Program
    {


    //    #region Method

    //    private static int validLength(string password)
    //    {
    //        if (password.Length >= 6 && password.Length <= 15)
    //            return 1;
    //        else
    //            return 0;

    //    }
    //    private static int containSpace(string password)
    //    {
    //        if (password.Contains(" "))
    //            return -1;
    //        else
    //            return 0;
    //    }

    //    private static int containDigit(string password)
    //    {
    //        int count = 0;

    //        for (int i = 0; i < 9; i++)
    //        {
    //            string str = i.ToString();

    //            if (password.Contains(str))
    //            {
    //                count = 1;
    //            }
    //        }
    //        return count;
    //    }

    //    private static int containSpecialChar(string password)
    //    {
    //        if (!(password.Contains("@") || password.Contains("#")
    //        || password.Contains("!") || password.Contains("~")
    //        || password.Contains("$") || password.Contains("%")
    //        || password.Contains("^") || password.Contains("&")
    //        || password.Contains("*") || password.Contains("(")
    //        || password.Contains(")") || password.Contains("-")
    //        || password.Contains("+") || password.Contains("/")
    //        || password.Contains(":") || password.Contains(".")
    //        || password.Contains(", ") || password.Contains("<")
    //        || password.Contains(">") || password.Contains("?")
    //        || password.Contains("|")))
    //        {
    //            return 1;
    //        }
    //        else
    //            return 0;
    //    }
    //    public static bool ContainSpecialChar(string password)
    //    {
    //        string specialCh = @"%!@#$%^&*()?/>.<,:;'\|}]{[_~`+=-" + "\"";
    //        char[] specialChArray = specialCh.ToCharArray();
    //        foreach (char ch in specialChArray)
    //        {
    //            if (password.Contains(ch))
    //                return true;
    //        }
    //        return false;
    //    }
        


    //private static int containCapitalLetter(string password)
    //    {
    //        int count = 0;

    //        for (int i = 65; i < 90; i++)
    //        {
    //            char c = (char)i;
    //            string str1 = c.ToString();
    //            if (password.Contains(str1))
    //                count = 1;
    //        }
    //        return count;
    //    }


    //    private static int containSmallLetter(string password)
    //    {
    //        int count = 0;

    //        for (int i = 90; i < 122; i++)
    //        {
    //            char c = (char)i;
    //            string str2 = c.ToString();

    //            if (password.Contains(str2))
    //                count = 1;

    //        }
    //        return count;
    //    }



    //    public static bool isValid(string password)
    //    {
    //        int num = containSmallLetter(password) +
    //            containCapitalLetter(password)
    //            + containSpecialChar(password)
    //            + containDigit(password)
    //            + containSpace(password)
    //            + validLength(password);

    //        if (num == 5)
    //        {
    //            return false;
    //        }
    //        else
    //            return true;

    //    }

        public static string CheckPassword(string password)
        {
            PasswordValidator PasswordValidatorC = new PasswordValidator();
            int count = 0;
            if (PasswordValidatorC.containSpecialChar(password) == true)
                count++;
            if (PasswordValidatorC.containCapitalLetter(password) == true)
                count++;
            if (PasswordValidatorC.containSmallLetter(password) == true)
                count++;
            if (PasswordValidatorC.containDigit(password) == true)
                count++;
            if (PasswordValidatorC.containSpace(password) == false)
                count++;
            if (PasswordValidatorC.validLength(password) == true)
                count++;


            if (count == 6)
                return "Strong Password";
            else if (count > 4 && PasswordValidatorC.containSpace(password) == false)
                return "average password";
            else
                return "weak password";


            //if (PasswordValidatorC.containSpecialChar(password)==true && 
            //    PasswordValidatorC.containCapitalLetter(password)==true 
            //    && PasswordValidatorC.containSmallLetter(password)==true && PasswordValidatorC.containDigit(password)==true
            //    && PasswordValidatorC.containSpace(password)==false && PasswordValidatorC.validLength(password)==true)
            //    return "Strong Password";


        }



        







        static void Main(string[] args)
        {

            //Console.WriteLine("1 For");

           


            int? initializer = 1;

            while (initializer != 0)
            {
                Console.WriteLine("ENter 1 for again Checking");
                Console.WriteLine("Enter 0 for exit");
                initializer = int.Parse(Console.ReadLine());

                switch (initializer)
                {
                    case 1:
                        {
                            Console.WriteLine("Enter password");
                            string password = Console.ReadLine();
                            Console.WriteLine(CheckPassword(password));
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
