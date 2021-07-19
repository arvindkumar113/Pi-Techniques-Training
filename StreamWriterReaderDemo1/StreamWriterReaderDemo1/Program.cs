using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

namespace StreamWriterReaderDemo1
{
    class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            string filePath = @"C:\Users\Arvind.Sahu\Desktop\Assignment\IODemoFile.txt";
            Console.WriteLine("--------Writing into file---------");
            program.WriteIntoFile(filePath);
            Console.WriteLine("--------Writing Done file---------");

            Console.WriteLine("------Reading From File------");
            program.ReadFromFile(filePath);


            Console.ReadLine();

        }

        public void WriteIntoFile(string path)
        {
            StreamWriter writer = new StreamWriter(path, true);
            try
            {
                writer.WriteLine("Hello World !");

                string temp = String.Empty;

                do
                {
                    Console.WriteLine("Enter Name or -1 to exit");
                    temp = Console.ReadLine();
                    writer.WriteLine(temp);
                } while (temp != "-1");

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                writer.Close();

            }
        }

        public void ReadFromFile(string path)
        {
            StreamReader reader = new StreamReader(path);
            try
            {
                while (!reader.EndOfStream)
                {
                    Console.WriteLine(reader.ReadToEnd());
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                reader.Close();
            }

        }

    }
}
