using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class Rectangle
    {
        int length, width;

        public int Length
        {
            get { return length; }//read

            set { length = value; }//assignment
        }

        public int Width
        {
            get { return width; }//read

            set { width = value; }//assignment
        }
        public int getArea()
        {
            return length * width;
        }
    }
}
