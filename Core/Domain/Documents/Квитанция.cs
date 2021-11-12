using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Domain.Documents
{

    public class Квитанция : Документ
    {
        public static int DocTypeStatic { get => 1000; }
        public decimal СуммаПлатежа { get; set; }
        public string НомерЛицевогоСчета { get; set; }

        public Квитанция()
        {
            Name = "Квитанция";
        }
    }
}