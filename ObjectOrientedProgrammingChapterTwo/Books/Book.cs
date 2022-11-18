using System;
using System.Collections.Generic;
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
        public Book()
        {
        }
        public string Title
        {
            get
            {
                return title;
            }

            set
            {
                if (title.Length < minTitleLenght)
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
                string[] fullName = title.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                string secondName = fullName[fullName.Length - 1];
                bool c = Char.IsDigit(secondName, 0);
                if (c == true)
                {
                    throw new IOException("Author not valid");
                }
                this.author = value;
            }

        }

        public double Price
        {
            get
            {
                return price;
            }
            set
            {
                if (price <= 0)
                {
                    throw new IOException("Price not valid.");
                }
            }
        }
        public override string ToString()
        {
            return $"{title} - {author} - price: {price}";
        }
    }
}
