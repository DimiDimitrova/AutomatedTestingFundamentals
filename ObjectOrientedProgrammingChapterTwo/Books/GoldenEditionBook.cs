using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books;

public class GoldenEditionBook : Book
{
    public GoldenEditionBook(string title, string author, double price) : base(title, author, price)
    {
    }

    public override double Price
    {
        get => base.Price;
        set => base.Price = value * 0.3 + value;
    }

}


