using System;

namespace TestApp
{
    public class EsotericBook : Book
    {
        public EsotericBook(string title, int price, string barcode, int numOfPages, int maxAge) : base(title, price, barcode, numOfPages)
        {
            MaxAge = maxAge;
            Order += ".3";
        }
        public int MaxAge { get; set; }
        public override string ToString()
        {
            return $"Книга {Title} по эзотерике для читателей моложе {MaxAge},{Environment.NewLine} {base.ToString()}" ;
        }

    }
}
