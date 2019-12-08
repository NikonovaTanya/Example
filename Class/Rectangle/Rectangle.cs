using System;
using System.Collections.Generic;
using System.Text;

namespace Rectangle
{
    class Rectangle
    {
        private double side1, side2;
        private double area, perimetr;

        public double Side1
        {
            get
            { return side1; }
            set
            {
                side1 = value;
            }

        }
        public double Side2
        {
            get
            { return side2; }
            set
            {
                side2 = value;
            }

        }

        public double Area
        {
            get
            { return area; }
        }
        public double Perimetr
        {
            get
            { return perimetr; }
        }
        public Rectangle()
        { }
        public Rectangle(double a, double b)
        {
            Side1 = a;
            Side2 = b;
        }
        public void AreaCalculation(double a, double b)
        {
            if (a > 0 && b > 0)
                area = a * b;
            else
                area = -1;
        }
        public void PerimetrCalculation(double a, double b)
        {
            if (a > 0 && b > 0)
                perimetr = 2 * (a + b);
            else
                perimetr = -1;
        }


    }
}
