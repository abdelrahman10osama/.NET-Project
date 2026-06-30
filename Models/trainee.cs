using System.ComponentModel.DataAnnotations.Schema;
namespace WebApplication2.Models
{
    public class trainee
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Image { get; set; }

        public string Adress { get; set; }

        public int dept_id { get; set; }

        [ForeignKey("dept_id")]
        public department Department { get; set; }
    }
}
