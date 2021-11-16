using System;
using System.ComponentModel.DataAnnotations;

namespace Core.Domain.Documents.Common.Attributes
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
    internal class StringPatternAttribute : ValidationAttribute
    {
        private string pattern;

        public StringPatternAttribute(string pattern)
        {
            this.pattern = pattern;
        }

        public override bool IsValid(object propValue)
        {
            // TODO: Сделать более сложный паттерн через regex
            return propValue.ToString().StartsWith(pattern);
        }
    }
}
