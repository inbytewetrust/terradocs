using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Domain.Documents
{
    public class ПлатежноеПоручение : Документ
    {
        public static int DocTypeStatic { get => 3000; }
        public int Номер { get; set; }
        public DateTime Дата { get; set; }
        public string ВидПлатежа { get; set; }
        public int СтатусПлательщика { get; set; }
        public string СуммаПлатежаПрописью { get; set; }
        public decimal СуммаПлатежаЦифрами { get; set; }

        public ПлатежноеПоручение()
        {
            Name = "Платежное поручение";
        }
    }
}
