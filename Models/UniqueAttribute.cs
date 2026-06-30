using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Models
{
    public class UniqueAttribute : ValidationAttribute
    {

        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            string? name = value?.ToString();

            coursewithDept? crsFromRequest =
                validationContext.ObjectInstance as coursewithDept;

            if (crsFromRequest == null)
            {
                return ValidationResult.Success;
            }

            company context = (company)validationContext.GetService(typeof(company));
            course? crsFromDB = context.Courses.FirstOrDefault(c =>
                c.Name == name &&
                c.dept_id == crsFromRequest.dept_id);

            if (crsFromDB == null)
            {
                return ValidationResult.Success;
            }

            return new ValidationResult("Course already exists in this department.");
        }


    }
}
