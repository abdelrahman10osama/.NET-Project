using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Models
{
    public class lessThanAttribute : ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            coursewithDept? model = validationContext.ObjectInstance as coursewithDept;

            if (model == null)
                return ValidationResult.Success;

            if (model.MinDegree < model.Degree)
            {
                return ValidationResult.Success;
            }

            return new ValidationResult("MinDegree must be less than Degree.");
        }
    }
}