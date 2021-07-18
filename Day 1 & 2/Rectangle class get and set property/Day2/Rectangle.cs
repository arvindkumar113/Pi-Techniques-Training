using System;
using System.Collections.Generic;
using System.Text;

namespace Day2
{
    class Rectangle
    {
        private int length;
        private int width;
        public int Length 
        {
            get { return length; }
            set { length = value; }
        }
        public int Width 
        { 
            get { return width; }
            set { width = value; } 
        }
        //Constructor without parameter
        public Rectangle()
        {
            Length = 0;
            Width = 0;
        }

        //constructor with parameter
        public Rectangle(int len, int wid)
        {
            Length = len;
            width = wid;
        }


        public override string ToString()
        {
            return string.Format($"Length={Length}, Width={Width}");
        }

        public int GetArea()
        {
            return Length * Width;
        }
    }
}
