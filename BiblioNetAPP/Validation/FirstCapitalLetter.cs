using System.ComponentModel.DataAnnotations;

namespace BiblioNetAPP.Validation
{
    public class FirstCapitalLetter  : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value == null || string.IsNullOrEmpty(value.ToString()))
            {
                return ValidationResult.Success;
            }
            var firstLetter = value.ToString()[0].ToString();
            if (firstLetter != firstLetter.ToUpper()) // el ToUpper verifica si la letra es mayuscula
            {
                return new ValidationResult("the first letter must be in uppercase");
            }
            return ValidationResult.Success;
        }
    }
}
