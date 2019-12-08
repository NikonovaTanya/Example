using System;
using System.Collections.Generic;
using System.Text;

namespace Book
{
    class Author
    {
        private string autorBook;
        public string AutorBook
        {
            get
            {
                return autorBook;
            }
            set
            {
                autorBook = value;
            }
        }

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Book title: " + autorBook);
            Console.WriteLine();
        }
    }
}
