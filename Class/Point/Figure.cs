using System;
using System.Collections.Generic;
using System.Text;

namespace Point
{
    class Figure
    {
        static int n;
        public Figure()
        {
        }
        public Figure(Point[] p)
        {
            Random rm = new Random();
            n = rm.Next(3, 6);
            Random rand = new Random();
            for (int i = 0; i < n; i++)
            {
                char tmp = (char)rand.Next('A', 'Z' + 1);
                p[i] = new Point(rm.Next(-50, 101), rm.Next(-50, 101), tmp.ToString());
                Console.Write("Point: " + p[i].Title + "  ");
                Console.Write("x=" + p[i].X + "   ");
                Console.Write("y=" + p[i].Y + "   ");
                Console.WriteLine();
            }
        }
        private double LengthSide(Point A, Point B)
        {
            double lenghtSide = 0;
            lenghtSide = Math.Abs(Math.Sqrt(Math.Pow((B.X - A.X), 2) + Math.Pow((B.Y - A.Y), 2)));
            Console.Write(A.Title + B.Title + ": ");
            Console.WriteLine(lenghtSide);
            return lenghtSide;
        }
        public double PerimeterCalculator(params Point[] p)
        {
            double perimeter = 0;
            for (int i = 0; i < n - 1; i++)
            {
                perimeter += this.LengthSide(p[i], p[i + 1]);
            }
            perimeter += this.LengthSide(p[n - 1], p[0]);
            for (int i = 0; i < n; i++)
            {
                Console.Write(p[i].Title);
            }
            Console.Write(" ");
            return perimeter;
        }
    }
}