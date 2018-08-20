using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp
{
    public class BookOnCulinary : Book
    {
        public BookOnCulinary(string title, int price, string barcode, int numOfPages, string basicIngredient) : base(title, price, barcode, numOfPages)
        {
            BasicIngredient = basicIngredient;
        }
        public string BasicIngredient { get; private set; }
        public override string ToString()
        {
            return $"Книга {Title} по приготовлению {BasicIngredient}, " + base.ToString();
        }
    }
}
