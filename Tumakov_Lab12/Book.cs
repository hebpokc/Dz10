using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tumakov_Lab12
{
    public class Book
    {
        string name;
        string author;
        string publisher;
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
        public string Author
        {
            get
            {
                return author;
            }
            set
            {
                author = value;
            }
        }
        public string Publisher
        {
            get
            {
                return publisher;
            }
            set
            {
                publisher = value;
            }
        }
        public Book(string name, string author, string publisher)
        {
            this.name = name;
            this.author = author;
            this.publisher = publisher;
        }
        public override string ToString()
        {
            return $"\nНазвание: {name}\nАвтор: {author}\nИздательство: {publisher}";
        }
    }
}
