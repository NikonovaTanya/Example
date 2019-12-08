using System;
using System.Collections.Generic;
using System.Text;

namespace Point
{
    class Point
    {
        private int x;
        private int y;

        private string title;


        public int X
        {
            get
            { return x; }

        }
        public int Y
        {
            get
            { return y; }
        }


        public string Title
        {
            get
            {
                return title;
            }
        }
        public Point() : this(0, 0, "")
        {
        }

        public Point(int x, int y, string t)
        {
            this.x = x;
            this.y = y;
            this.title = t;

        }


    }
}

