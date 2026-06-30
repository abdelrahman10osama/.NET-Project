using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Models
{
    public class coursewithDept
    {

        public int Id { get; set; }
        [Required(ErrorMessage = "please put course name")]
        [MaxLength(25, ErrorMessage = "name range must be 2 : 25 length")]
        [MinLength(2, ErrorMessage = "name range must be 2 : 25 length")]
        [Unique]
        public string Name { get; set; }
        [Range(50, 100,ErrorMessage = "Degree Range Must be within 50:100")]
        public int Degree { get; set; }
        [lessThan]
        public int MinDegree { get; set; }
        [Divided]
        public int Hours { get; set; }

        public int dept_id { get; set; }
        public List<department> DepartmentList { get; set; } = new();
        public int CourseId { get; set; }
    }
}
