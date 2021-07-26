using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;



namespace Async_await_demo2
{
    class Program
    {
        static void Main(string[] args)
        {
            Task task = new Task(CallMethod);
            task.Start();
            task.Wait();
            Console.ReadLine();
        }
        static async void CallMethod()
        {
            string filePath = "E:\\sampleFile.txt";
            Task<int> task = ReadFile(filePath);

            Console.WriteLine(" Other Work 1");
            Console.WriteLine(" Other Work 2");
            Console.WriteLine(" Other Work 3");

            int length = await task;
            Console.WriteLine(" Total length: " + length);

            Console.WriteLine(" After work 1");
            Console.WriteLine(" After work 2");
        }

        static async Task<int> ReadFile(string file)
        {
            int length = 0;

            Console.WriteLine(" File reading is stating");
            using (StreamReader reader = new StreamReader(file))
            {
                // Reads all characters from the current position to the end of the stream asynchronously
                // and returns them as one string.
                string s = await reader.ReadToEndAsync();

                length = s.Length;
            }
            Console.WriteLine(" File reading is completed");
            return length;
        }
    }
}
