using System.ComponentModel.DataAnnotations.Schema;

namespace School.Data.Entities
{
    public class Degree
    {
        public int Id { get; set; }
        public double Score { get; set; }
        public string AcademicGrad { get; set; }
        //relations
        //Subject degree
        public int SubjId { get; set; }
        [ForeignKey("SubjId")]
        public Subject Subject { get; set; }

    }
}
