using System.ComponentModel.DataAnnotations;

namespace School.Data.Entities
{
    public partial class Department
    {

        [Key]
        public int DID { get; set; }
        [StringLength(500)]
        public string DName { get; set; }

        // Student Department
        public virtual ICollection<Student> Students { get; set; }
        //Teacher Department
        public virtual ICollection<Teacher> Teachers { get; set; }
        // ClassRoom Department
        public virtual ICollection<ClassRoom> Classrooms { get; set; }
        // Subject Department
        public virtual ICollection<Subject> Subjects { get; set; }
    }


}
