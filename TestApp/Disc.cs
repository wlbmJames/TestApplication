using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestApp.Enums;

namespace TestApp
{
    public class Disc : Product
    {
        public Disc(string title, int price, string barcode, DiscType type, DiscContent content) : base(title, price, barcode)
        {
            Type = type;
            Content = content;
        }

        public DiscType Type { get; private set; }
        public DiscContent Content { get; private set; }
        string _tmpContent;
        public override string ToString()
        {
            if (Content == DiscContent.Music) _tmpContent = "музыкой";
            else if (Content == DiscContent.Video) _tmpContent = "видео";
            else if (Content == DiscContent.Software) _tmpContent = "ПО";
            else _tmpContent = "ОШИБКА!!";
            return $@"{Type} диск {Title} с {_tmpContent}, цена {Price}, штрих-код {Barcode}";
        }

    }
}
