using System;

namespace Employee
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee e = new Employee("Tanya", "Nikonova");
            Console.WriteLine(e.Name+"     "+e.Surname);
            Console.WriteLine("salary: "+e.salary("programmer", 15));

        }
    }
}
