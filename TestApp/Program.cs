using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestApp.Enums;

namespace TestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            BookOnProgramming schildtBook = new BookOnProgramming("Шилдт Основы программирования", 1000, "1313-13", 750, "C#");
            BookOnCulinary culinary = new BookOnCulinary("Рецепты", 300, "123-13", 140, "Курица");
            BookOnEsoteric esoteric = new BookOnEsoteric("Мистика и эзотерика", 450, "14234-43", 470, 45);
            Disc windowsDistr = new Disc("Дистрибутив Windows", 1200, "12412-41-14", DiscType.DVD, DiscContent.Software);
            Disc metallica = new Disc("Сборник Metallica", 500, "313-213", DiscType.CD, DiscContent.Music);
            Console.WriteLine(schildtBook.ToString());
            Console.WriteLine(culinary.ToString());
            Console.WriteLine(esoteric.ToString());
            Console.WriteLine(windowsDistr.ToString());
            Console.WriteLine(metallica.ToString());
            Console.ReadKey();
        }

    }
}
