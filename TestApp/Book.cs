using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp
{
    public abstract class Book : Product
    {
        public Book(string title, int price, string barcode, int numOfPages) : base(title, price, barcode)
        {
            NumderOfPages = numOfPages;
        }
        public int NumderOfPages { get; private set; }
        public override string ToString()
        {
            return $"цена {Price}р, кол-во страниц {NumderOfPages}, шрих-код {Barcode}";
        }

    }
}
