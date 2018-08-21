using System;
using System.Collections.Generic;
using System.Linq;
using TestApp.Enums;

namespace TestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<Product>();
            list.Add(new DeveloperBook("Шилдт Основы программирования", 1000, "1313-13", 750, "C#"));
            list.Add(new Disc("Дистрибутив Windows", 1200, "12412-41-14", DiscType.DVD, DiscContent.Software));
            list.Add(new Disc("Сборник Metallica", 500, "313-213", DiscType.CD, DiscContent.Music));
            list.Add(new EsotericBook("Мистика и эзотерика", 450, "14234-43", 470, 45));
            list.Add(new CulinaryBook("Рецепты", 300, "123-13", 140, "Курица"));
            list.OrderBy(p=>p.Order).ThenBy(p=>p.Title).ToList().ForEach(Console.WriteLine);

            Console.ReadKey();
        }

    }
}
