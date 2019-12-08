using System;

namespace Book
{
    class Program
    {
        static void Main(string[] args)
        {
            Title tbook = new Title();
            Author abook = new Author();
            Content cbook = new Content();
            Console.WriteLine("Enter title: ");
            tbook.TitleBook = Console.ReadLine();
            Console.WriteLine("Enter autor book: ");
            abook.AutorBook = Console.ReadLine();
            Console.WriteLine("Enter content book: ");
            cbook.ContentBook = Console.ReadLine();
            Book bbook = new Book(tbook, abook, cbook);
            Console.WriteLine("-------------------------------------------------");
            bbook.Show();


        }
    }
}

