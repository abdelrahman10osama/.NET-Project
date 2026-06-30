using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Models
{
    public class DividedAttribute:ValidationAttribute
    {

        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            coursewithDept? model = validationContext.ObjectInstance as coursewithDept;

            if (model == null)
                return ValidationResult.Success;

            if (model.Hours % 3 == 0)
            {
                return ValidationResult.Success;
            }

            return new ValidationResult("Hours must be divisible by 3. .");
        }

    }
}
