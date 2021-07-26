using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
//namespace System.Text;

namespace StringBuilderProgram
{
    class Program
    {
        public static void concat1(String s1)
        {

            // taking a string which
            // is to be Concatenate
            String st = "Kumar";

            // using String.Concat method
            // you can also replace it with
            // s1 = s1 + "Kumar";
            s1 = String.Concat(s1, st);
        }

        // Concatenates to StringBuilder
        public static void concat2(StringBuilder s2)
        {

            // using Append method
            // of StringBuilder class
            s2.Append("Kumar");
        }


        static void Main(string[] args)
        {
            String s1 = "Arvind";
            concat1(s1); // s1 is not changed
            Console.WriteLine("Using String Class: " + s1);

            StringBuilder s2 = new StringBuilder("Arvind");
            concat2(s2); // s2 is changed
            Console.WriteLine("Using StringBuilder Class: " + s2);

            Console.ReadLine();
        }
    }
} 
