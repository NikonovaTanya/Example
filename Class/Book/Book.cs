using System;
using System.Collections.Generic;
using System.Text;

namespace Book
{
    class Book
    {
        private Title t;
        private Author a;
        private Content c;

        public Book()
        { }

        public Book(Title t1, Author a1, Content c1)
        {
            t = t1;
            a = a1;
            c = c1;
        }

        public void Show()
        {
            t.Show();
            a.Show();
            c.Show();
        }
    }
}
