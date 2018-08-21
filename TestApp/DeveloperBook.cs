using System;
namespace TestApp
{
 
    public class DeveloperBook : Book
    {
        
        public DeveloperBook(string title, int price, string barcode, int numOfPages, string progLanguage) : base(title, price, barcode, numOfPages)
        {
            ProgrammingLanguage = progLanguage;
            Order += ".1";
        }
        public string ProgrammingLanguage { get; private set; }
        
        public override string ToString()
        {
            return $"Книга {Title} по программированию на языке {ProgrammingLanguage},{Environment.NewLine} {base.ToString()}";     
        }
    }
}
