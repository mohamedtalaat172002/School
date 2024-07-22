using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace School.Data.Entities
{
    public class Subject
    {
        [Key]
        public int SubID { get; set; }
        [StringLength(500)]
        public string SubjectName { get; set; }


        //Relations
        //Subject student
        public virtual ICollection<Student> Students { get; set; }
        // Subject Teacher
        public virtual ICollection<Teacher> Teachers { get; set; }
        // Subject grad
        public int GradID { get; set; }
        [ForeignKey("GradID")]
        public Grade Grade { get; set; }
        // SUBJECT Department
        public int DepId { get; set; }
        [ForeignKey("DepId")]
        public Department Department { get; set; }
        //Subject Degree
        public Degree degree { get; set; }

    }


}
