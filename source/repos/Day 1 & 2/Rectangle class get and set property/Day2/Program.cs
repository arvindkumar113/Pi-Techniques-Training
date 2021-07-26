using System;

namespace Day2
{
    class Program
    {
        static void Main(string[] args)
        {
            //calling constructor without parameter
            Rectangle rectangle1 = new Rectangle();
            Console.WriteLine(rectangle1.ToString());

            //calling constructor with parameter
            Rectangle rectangle2 = new Rectangle(10, 12);
            Console.WriteLine(rectangle2.ToString());

            //explicitly giving the value to length and width
            Rectangle rectangle = new Rectangle();
            rectangle.Length = 10;
            rectangle.Width=20;
            Console.WriteLine(rectangle.ToString());

            //Area of rectangle
            Console.WriteLine("Area of rectangle is : " + rectangle.GetArea());

            

            Console.ReadLine();
        }



    }
}
