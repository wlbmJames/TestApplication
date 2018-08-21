using System;
using TestApp.Enums;

namespace TestApp
{
    public class Disc : Product
    {
        public Disc(string title, int price, string barcode, DiscType type, DiscContent content) : base(title, price, barcode)
        {
            Type = type;
            Content = content;
            Order = $"2.{(int)Type}{(int)Content}";
        }

        public DiscType Type { get; }
        public DiscContent Content { get; }

        public override string ToString()
        {
            string tmpContent;
            switch (Content)
            {
                case DiscContent.Music:
                    tmpContent = "музыкой";
                    break;
                case DiscContent.Video:
                    tmpContent = "видео";
                    break;
                case DiscContent.Software:
                    tmpContent = "ПО";
                    break;
                default:
                    tmpContent = "ОШИБКА!!";
                    break;
            }
            return $@"{Type} диск {Title} с {tmpContent}, цена {Price}, штрих-код {Barcode} {Environment.NewLine}";
        }

    }
}
    