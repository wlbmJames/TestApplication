using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp
{
 
    public class BookOnProgramming : Book
    {
        public BookOnProgramming(string title, int price, string barcode, int numOfPages, string progLanguage) : base(title, price, barcode, numOfPages)
        {
            ProgrammingLanguage = progLanguage;
        }
        public string ProgrammingLanguage { get; private set; }
        
        public override string ToString()
        {
            return $"Книга {Title} по программированию на языке {ProgrammingLanguage}, " + base.ToString();        
        }
    }
}
