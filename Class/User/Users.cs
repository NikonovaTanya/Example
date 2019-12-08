using System;
using System.Collections.Generic;
using System.Text;

namespace User
{
    class Users
    {
        public readonly DateTime date;
        private string login;
        private string name;
        private string surname;
        private int age;
        public Users()
        {
            date = DateTime.Now;
            Console.Write("Enter login: ");
            Login = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Enter name: ");
            Name = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Enter surname: ");
            Surname = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Enter age: ");
            age = int.Parse(Console.ReadLine());
            Console.WriteLine();
        }
        public string Login
        {
            get
            {
                return login;
            }
            set
            {
                login = value;
            }
        }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public string Surname
        {
            get
            {
                return surname;
            }
            set
            {
                surname = value;
            }
        }
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                if (value > 0)
                    age = value;
            }
        }
        public void print()
        {
            Console.WriteLine("Date: " + this.date);
            Console.WriteLine("Login: " + this.login);
            Console.WriteLine("Name: " + this.name);
            Console.WriteLine("Surname: " + this.surname);
            Console.WriteLine("Age: " + this.age);

        }
    }
}
