using System;
using System.Collections.Generic;
using System.Text;

namespace Employee
{
    class Employee
    {
        private string surname;
        private string name;
        public string Surname {get;set;}
        public string Name { get; set; }
        public Employee() { }
        public Employee(string n, string s)
        {
            this.Name = n;
            this.Surname = s;
        }
        public double salary(string position, double experience)
        {
            Console.WriteLine(position);
            double salaryEmployee=0;
            double premium=0;
            if (position == "programmer")
                salaryEmployee = 400;
            if (position == "economist")
                salaryEmployee = 350;
            if (position == "manager")
                salaryEmployee = 450;
            if (experience > 0 && experience < 5)
                premium = 0.05;
            if (experience >= 5 && experience < 10)
                premium = 0.1;
            if (experience >= 10 && experience < 15)
                premium = 0.2;
            if (experience >= 15)
                premium = 0.4;
            double result = salaryEmployee + salaryEmployee * premium;
            Console.WriteLine("tax levy:   "+ result*0.195);
            return result;
        }


    }
}
