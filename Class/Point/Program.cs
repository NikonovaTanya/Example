using System;

namespace Point
{
    class Program
    {
        static void Main(string[] args)
        {
            Point[] p = new Point[5];
            Figure f = new Figure(p);
            Console.WriteLine("perimetr: " + f.PerimeterCalculator(p));
        }
    }
}
