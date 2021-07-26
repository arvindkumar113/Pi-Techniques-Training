using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Async_await_demo3
{
    class Program
    {
        static void Main(string[] args)
        {
            Method1();
            Method2();
            Console.ReadKey();
        }

        public static async Task Method1()
        {
            await Task.Run(() =>
            {
                for (int i = 0; i < 20; i++)
                {
                    Console.WriteLine(" Method 1");
                    // Do something
                    Task.Delay(100).Wait();
                }
            });
        }


        public static void Method2()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(" Method 2");
                // Do something
                Task.Delay(100).Wait();
            }
        }
    }
}

