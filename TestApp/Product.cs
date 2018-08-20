using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp
{
    public abstract class Product
    {
        public Product(string title, int price, string barcode)
        {
            Title = title;
            Price = price;
            Barcode = barcode;
        }
        public string Title { get; private set; }
        public int Price { get; set; }
        public string Barcode { get; set; }
    }
}
