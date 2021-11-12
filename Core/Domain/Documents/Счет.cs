using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Core.Domain.Documents.Common;

namespace Core.Domain.Documents
{
    public class Счет : Документ
    {
        public static int DocTypeStatic { get => 2000; }
        public string Адрес { get; set; }
        public string Телефон { get; set; }
        public string Получатель { get; set; }
        public string Плательщик { get; set; }
        public string БанкПолучателя { get; set; }
        public string Основание { get; set; }

        public Счет()
        {
            Name = "Счет";
        }
    }
}
