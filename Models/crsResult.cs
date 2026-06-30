using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication2.Models
{
    public class crsResult
    {
        public int Id { get; set; }

        public int Degree { get; set; }

        public int crs_id { get; set; }

        public int trainee_id { get; set; }

        [ForeignKey(nameof(crs_id))]
        public course Course { get; set; }

        [ForeignKey(nameof(trainee_id))]
        public trainee Trainee { get; set; }
    }
}
