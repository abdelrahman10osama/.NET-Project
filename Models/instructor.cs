using System.ComponentModel.DataAnnotations.Schema;
namespace WebApplication2.Models
{
    public class instructor
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Image { get; set; }

        public int Salary { get; set; }

        public string Adress { get; set; }

        public int dept_id { get; set; }

        public int crs_id { get; set; }

        [ForeignKey("dept_id")]
        public department Department { get; set; }

        [ForeignKey("crs_id")]
        public course Course { get; set; }
    }
}
