using System;
using System.Collections.Generic;
using System.Text;

namespace Book
{
    class Content
    {
        private string contentBook;
        public string ContentBook
        {
            get
            {
                return contentBook;
            }
            set
            {
                contentBook = value;
            }
        }

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Book content: " + contentBook);
            Console.WriteLine();
        }
    }
}
