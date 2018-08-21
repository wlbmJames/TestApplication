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
        
        public string Title { get; }
        public int Price { get; set; }
        public string Barcode { get; set; }
        public string Order { get; protected set; }
    }
}
