using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tumakov_Lab12
{
    class BookContainer
    {
        List<Book> books;
        public List<Book> Books
        {
            get
            {
                return books;
            }
        }
        public BookContainer()
        {
            books = new List<Book>();
        }
        public void Sort(Comparison c)
        {
            books = books.OrderBy(x => c.Invoke(x)).ToList();
        }
        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            if (books.Count > 0)
            {
                books.ForEach(x => builder.AppendLine(x.ToString()));
            }
            else
            {
                builder.Append("Пусто");
            }
            return builder.ToString();
        }
    }
    public delegate string Comparison(Book a);
}
