using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwapUsingGenericClass
{
    class Program
    {
        static void Swap<T>(ref T input1,ref T input2)
        {
            T temp = input1;
            input1 = input2;
            input2 = temp;
        }

        static void Main(string[] args)
        {

            int x = 10, y = 20;
            Console.WriteLine("Number before Swap " + x + " and " + y);
            Swap(ref x, ref y);
            Console.WriteLine("Number after Swap " + x + " and " + y);

            Console.WriteLine();


            string str1 = "Arvind";
            string str2 = "Kumar";
            Console.WriteLine("String before Swap " + str1 + "  " + str2);
            Swap(ref str1, ref str2);
            Console.WriteLine("String after Swap  " + str1 + "  " + str2);

            Console.ReadLine()
;        }
    }
}
