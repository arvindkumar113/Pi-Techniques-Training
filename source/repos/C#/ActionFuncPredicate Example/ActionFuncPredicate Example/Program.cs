using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActionFuncPredicate_Example
{
    class Program
    {
        //Func Delegate last input paramaeter is always output parameter
        public delegate FuncResult Func<in T, FuncResult>(T arg);

        //Action delegate always return void 
        public delegate void Print(int val);

        //predicate delegate return only bool type i.e mixture of Func and Action
        public delegate bool Prediction<in T>(T obj);



        static int Sum(int num1, int num2)
        {
            return num1 + num2;
        }

        static void ConsolePrint(int val)
        {
            Console.WriteLine("Printing using Action : " + val);
        }
        static bool Contains_attherate(string str)
        {
            return str.Contains("@");
        }


        static void Main(string[] args)
        {
            Func<int, int, int> add = Sum;
            Console.WriteLine("Addition using Func Delegate" + add(10, 20));

            ConsolePrint(add(20, 30));

            string s = "arvindsahu@pitechniques.com";

            bool res = Contains_attherate(s);
            Console.WriteLine("String contain @ " + res);




        }
    }
}
