using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp
{
    public class BookOnEsoteric : Book
    {
        public BookOnEsoteric(string title, int price, string barcode, int numOfPages, int maxAge) : base(title, price, barcode, numOfPages)
        {
            MaxAge = maxAge;
        }
        public int MaxAge { get; set; }
        public override string ToString()
        {
            return $"Книга {Title} по эзотерике для читателей моложе {MaxAge}, " + base.ToString();
        }

    }
}
