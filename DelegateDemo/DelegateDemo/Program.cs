using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateDemo
{
    //1st method to create delegate
    delegate int CalculateDelegate(int first, int second);

    class Program
    {
        //2nd method
        static int AddNum(int num1, int num2)
        {
            return num1 + num2;
        }

        static int Mul(int num1, int num2)
        {
            return num1 * num2;
        }

        static void Main(string[] args)
        {

            //3rd step
            CalculateDelegate delobj = new CalculateDelegate(Mul);

            CalculateDelegate delegobj = AddNum;
            int result = delegobj(1, 2);



            Console.WriteLine("Result is : " + result);



            int res = delobj(4, 5);
            Console.WriteLine("Mul result is : " + res);




            CalculateDelegate delobj2 = delegate (int num1, int num2)
            {
                return num1 - num2;
            };

            int res1 = delobj2(32, 12);
            Console.WriteLine("Substraction is :" + res1);


            CalculateDelegate deleobj3 = (i, j) => i * j;
            res1 = deleobj3(3, 4);
            Console.WriteLine("Result os multiplicaton : " + res1);

            string message1 = "Hello I am Arvind from Pi techniques";

            int count = 0;
            while(message1.Length!=0)
            {
                if(message1[])

            }



            Console.ReadLine();
        }
    }
}
