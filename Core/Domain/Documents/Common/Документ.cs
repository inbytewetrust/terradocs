using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Core.Domain.Documents.Common
{
    public abstract class Документ : IValidatableObject
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int DocType { get; set; }

        public virtual IEnumerable<ValidationResult> Validate(ValidationContext context)
        {
            var errors = new List<ValidationResult>();

            return errors;
        }
    }
}
