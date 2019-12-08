using System;
using System.Collections.Generic;
using System.Text;

namespace Class
{
    class Address
    {
        private int index;
        private string country;
        private string street;
        private int house;
        private string apartment;
        public int Index
        {
            set
            {
                if (value < 0)
                    Console.WriteLine(" Index < 0");
                else
                    index = value;

            }
            get { return index; }
        }

        public string Country
        {
            set
            {
                country = value;
            }
            get
            {
                return country;
            }
        }
        public string Street
        {
            set
            {
                street = value;
            }
            get
            {
                return street;
            }
        }
        public int House
        {
            set
            {
                if (value < 0)
                    Console.WriteLine(" House < 0");
                else
                    house = value;
            }
            get { return house; }
        }
        public string Apartment
        {
            set
            {
                apartment = value;
            }
            get
            {
                return apartment;
            }
        }

        public void inputAdress()
        {
            Console.Write("Index: ");
            Index = int.Parse(Console.ReadLine());
            Console.Write("Country: ");
            Country = Console.ReadLine();
            Console.Write("Street: ");
            Street = Console.ReadLine();
            Console.Write("House: ");
            House = int.Parse(Console.ReadLine());
            Console.Write("Apartment: ");
            Apartment = Console.ReadLine();
        }
        public void outputAdress()
        {
            Console.Write("Index: " + index);
            Console.WriteLine();
            Console.Write("Country: " + country);
            Console.WriteLine();
            Console.Write("Street: " + street);
            Console.WriteLine();
            Console.Write("House: " + house);
            Console.WriteLine();
            Console.Write("Apartament: " + apartment);
        }
    }
}
