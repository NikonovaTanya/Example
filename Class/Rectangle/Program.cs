using System;

namespace Rectangle
    {
        class Program
        {
            static void Main(string[] args)
            {
                Rectangle r = new Rectangle(2, 4);
                Console.WriteLine("a="+r.Side1+"  b="+r.Side2);
                r.AreaCalculation(r.Side1, r.Side2);
                Console.Write("Area rectangle: " + r.Area);
                r.PerimetrCalculation(r.Side1, r.Side2);
                Console.WriteLine();
                Console.Write("Perimetr rectangle: " + r.Perimetr);
                Console.WriteLine();
                Console.WriteLine("------------------------------------------------");
                Console.Write("Enter a=");
                r.Side1 = double.Parse(Console.ReadLine());
                Console.Write("Enter b=");
                r.Side2 = double.Parse(Console.ReadLine());
                r.AreaCalculation(r.Side1, r.Side2);
                Console.Write("Area rectangle: " + r.Area);
                r.PerimetrCalculation(r.Side1, r.Side2);
                Console.WriteLine();
                Console.Write("Perimetr rectangle: " + r.Perimetr);

            }
        }
    }

