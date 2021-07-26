using System;

using System.Collections;
using System.Collections.Generic;
namespace MinMaxApp
{
    class Program
    {
         public struct MinMaxStruct
        {
            public int min4;
            public int max4;
        }

        static List<int> MinMaxCalc1(List<int> num)
        {
            List<int> res = new List<int>();
            res[0] = 0;
            res[1] = num[0];
            for (int i = 1; i < num.Count; i++)
            {
                if (res[0] > num[i])
                    res[0] = num[i];
                if (res[1] < num[i])
                    res[1] = num[i];


            }
            return res;
        }


        public static int MinMaxCalc2(List<int> numbers,ref int max1)
        {
            int min = numbers[0];
            for(int i=1; i<numbers.Count; i++)
            {
                if(numbers[i]<min)
                {
                    min = numbers[i];
                }
                if(numbers[i]>max1)
                {
                    max1 = numbers[i];
                }
            }
            return min;
        }

        public static int MinMaxCalc3(List<int> numbers,out int max2)
        {
            max2 = numbers[0];
            int min = 0;
            for(int i=1; i<numbers.Count; i++)
            {
                if(numbers[i]<min)
                {
                    min = numbers[i];
                }
                if(numbers[i]>max2)
                {
                    max2 = numbers[i];
                }
            }


            return min;
        }
        
        public static MinMaxStruct MinMaxCalc4(List<int> numbers)
        {
            MinMaxStruct res = new MinMaxStruct();

            res.min4 = numbers[0];
            res.max4 = numbers[0];
            for(int i=1; i<numbers.Count; i++)
            {
                if (res.min4 > numbers[i])
                    res.min4 = numbers[i];
                if (res.max4 < numbers[i])
                    res.max4 = numbers[i];
            }


            return res;
        }


        public static Tuple<int, int> MinMaxCal5(List<int> numbers)
        {
            int min5 = 0;
            int max5 = 0;
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] > min5)
                    min5 = numbers[i];
                if (numbers[i] > max5)
                    max5 = numbers[i];
            }

            return new Tuple<int, int>(min5, max5);
        }





        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            List<int> numbers = new List<int>() { 1, 3, 2, 4, 5, 7, 6, 9, 8 };
            Console.WriteLine("Numbers are :");
            for (int i = 0; i < numbers.Count; i++)
                Console.WriteLine(numbers[i]);
            
            //using list return type
            Console.WriteLine("Using List return type");
            List<int> res = MinMaxCalc1(numbers);
            Console.WriteLine("Minimum : " + res[0] + " Maximum : " + res[1]);

            Console.WriteLine("--------Using ref keyword---------");

            //using ref keyword
            int max1 = numbers[1];
            int min1 = MinMaxCalc2(numbers, ref max1);
            Console.WriteLine("Minimum : " + min1 + " Maximum : " + max1);

            Console.WriteLine("--------Using out keyword---------");

            int max2;
            int min2 = MinMaxCalc3(numbers, out max2);
            Console.WriteLine("Minimum : " + min2 + " Maximum : " + max2);

            Console.WriteLine("--------Using structure---------");

            MinMaxStruct result = MinMaxCalc4(numbers);
            Console.WriteLine("Minimum : " + result.min4 + " Maximum : " + result.max4);

            Console.WriteLine("--------Using Tuple---------");
            Tuple<int, int> tuple = MinMaxCal5(numbers);




            Console.ReadLine();
        }
    }
}
