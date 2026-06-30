using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication2.Models
{
    public class course
    {
        public int Id { get; set; }
   
        public string Name { get; set; }
        public int Degree { get; set; }

        public int MinDegree { get; set; }
        
        public int Hours { get; set; }

        public int dept_id { get; set; }

        [ForeignKey(nameof(dept_id))]
        public department Department { get; set; }
    }
}
