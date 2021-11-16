using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

using Core.Domain.Documents.Common;
using Core.Domain.Documents.Common.Attributes;

namespace Core.Domain.Documents
{

    public class Квитанция : Документ
    {
        public static int DocTypeStatic { get => 1000; }
        public decimal СуммаПлатежа { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Необходимо заполнить Номер Лицевого счета")]
        [StringPattern("НС-")]
        public string НомерЛицевогоСчета { get; set; }

        public Квитанция()
        {
            Name = "Квитанция";
        }

        public override IEnumerable<ValidationResult> Validate(ValidationContext context)
        {
            List<ValidationResult> errors = base.Validate(context).ToList();

            if (СуммаПлатежа <= 0)
                errors.Add(new ValidationResult("Сумма платежа должна быть больше нуля"));

            return errors;
        }
    }
}