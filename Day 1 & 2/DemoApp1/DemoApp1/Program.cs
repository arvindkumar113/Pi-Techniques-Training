using System;

namespace DemoApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello enter a number");
            int num;
            num=int.Parse(Console.ReadLine());
            if(num%2==0)
            {
                Console.WriteLine("Number is even");
                Console.Read();
            }
            else
            {
                Console.WriteLine("Number is odd");
                Console.Read();

            }

            Console.WriteLine("Check odd even till user want\n");
            CheckEvenOddTill();

            static void CheckEvenOddTill()
            {
                

                do
                {

                    Console.WriteLine("Enter a number to check even odd and enter 0 to exit");
                    int num1 = int.Parse(Console.ReadLine());
                    if (num1 % 2 == 0)
                    {
                        Console.WriteLine("Number is even");
                        Console.Read();
                    }
                    else
                    {
                        Console.WriteLine("Number is odd");
                        Console.Read();

                    }
                } while (true);
            }
                


        }

       static void CheckEvenOdd(int a)
        {
            if (a % 2 == 0)
                Console.WriteLine("Number is even");
            else
                Console.WriteLine("Number is odd");
        }
    }
}
