using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordCheck
{
    public class PasswordValidator
    {


        #region Method

        public   bool validLength(string password)
        {
            if (password.Length >= 6 && password.Length <= 15)
                return true;
            else
                return false;

        }
        public  bool containSpace(string password)
        {
            if (password.Contains(" "))
                return true;
            else
                return false;
        }

        public  bool containDigit(string password)
        {
            

            for (int i = 0; i < 9; i++)
            {
                string str = i.ToString();

                if (password.Contains(str))
                {
                    return true;
                }
            }
            return false;
        }

        public  bool containSpecialChar(string password)
        {
            if (!(password.Contains("@") || password.Contains("#")
            || password.Contains("!") || password.Contains("~")
            || password.Contains("$") || password.Contains("%")
            || password.Contains("^") || password.Contains("&")
            || password.Contains("*") || password.Contains("(")
            || password.Contains(")") || password.Contains("-")
            || password.Contains("+") || password.Contains("/")
            || password.Contains(":") || password.Contains(".")
            || password.Contains(", ") || password.Contains("<")
            || password.Contains(">") || password.Contains("?")
            || password.Contains("|")))
            {
                return true;
            }
            else
                return false;
        }

        public  bool containCapitalLetter(string password)
        {
            

            for (int i = 65; i < 90; i++)
            {
                char c = (char)i;
                string str1 = c.ToString();
                if (password.Contains(str1))
                    return true;
            }
            return false;
        }


        public  bool containSmallLetter(string password)
        {
            

            for (int i = 90; i < 122; i++)
            {
                char c = (char)i;
                string str2 = c.ToString();

                if (password.Contains(str2))
                    return true;

            }
            return false;
        }



        //public static bool isValid(string password)
        //{
        //    int num = containSmallLetter(password) +
        //        containCapitalLetter(password)
        //        + containSpecialChar(password)
        //        + containDigit(password)
        //        + containSpace(password)
        //        + validLength(password);

        //    if (num == 6)
        //    {
        //        return true;
        //    }
        //    else
        //        return false;

        //}

        #endregion



    }
}
