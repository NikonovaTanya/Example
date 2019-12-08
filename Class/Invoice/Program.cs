using System;

namespace Invoice
{
    class Program
    {
        static void Main(string[] args)
        {
            Invoice1 order = new Invoice1(251011,"Ivanov", "Petrov", "00001",5);
            Console.WriteLine(order.Account + "   " + order.Customer + "  " + order.Provider + " ");
            order.getCost();
            Console.WriteLine("Sum: " + Invoice1.sum + "     " + "Sum without VAT: " + Invoice1.sumWithoutVat);

            Console.WriteLine("Enter article: ");
            order.Article = Console.ReadLine();
            Console.WriteLine("Enter count: ");
            order.Quantity= int.Parse(Console.ReadLine());

            Console.WriteLine(order.Account + "   " + order.Customer + "  " + order.Provider + " ");
            order.getCost();
            Console.WriteLine("Sum: "+ Invoice1.sum+"     "+"Sum without VAT: "+Invoice1.sumWithoutVat);
        }
    }
}
