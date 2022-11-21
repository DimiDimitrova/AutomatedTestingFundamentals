using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Books
{
    public class Book
    {
        private string title;
        private string author;
        private double price;
        private static int minTitleLenght = 3;
        public Book(string title, string author, double price)
        {
            Title = title;
            Author = author;
            Price = price;
        }
        public string Title
        {
            get
            {
                return title;
            }

            set
            {
                if (value.Length < minTitleLenght)
                {
                    throw new IOException("Title not valid");
                }
                this.title = value;
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
                string[] fullName = value.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                string secondName = fullName[fullName.Length - 1];
                bool c = Char.IsDigit(secondName, 0);
                if (c == true)
                {
                    throw new IOException("Author not valid");
                }
                this.author = value;
            }

        }

        public virtual double Price
        {
            get
            {
                return price;
            }
            set
            {
                if (value <= 0)
                {
                    throw new IOException("Price not valid.");
                }
                price = value;
            }
        }
        public override string ToString()
        {
            return $"{title} - {author} - price: {price:0.0}";
        }
    }
}
