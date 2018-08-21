using System;

namespace TestApp
{
    public class CulinaryBook : Book
    {
        public CulinaryBook(string title, int price, string barcode, int numOfPages, string basicIngredient) : base(title, price, barcode, numOfPages)
        {
            BasicIngredient = basicIngredient;
            Order += ".2";
        }
        public string BasicIngredient { get; }
        public override string ToString()
        {
            return $"Книга {Title} по приготовлению {BasicIngredient},{Environment.NewLine} {base.ToString()}";
        }
    }
}
