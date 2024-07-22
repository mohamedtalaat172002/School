using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace School.Data.Entities
{
    public class Student
    {
        [Key]
        public int StudID { get; set; }
        [StringLength(200)]
        public string Name { get; set; }
        [StringLength(500)]
        public string Address { get; set; }
        [StringLength(500)]
        public string Phone { get; set; }

        //Relations

        //Student Clsroom 

        public int ClsRoomID { get; set; }
        [ForeignKey("ClsRoomID")]
        public ClassRoom ClassRoom { get; set; }
        //student subjects
        public ICollection<Subject> Subjects { get; set; }
        //student department
        public int? DID { get; set; }

        [ForeignKey("DID")]
        public virtual Department Department { get; set; }
        //Student Grad
        public int GradID { get; set; }
        [ForeignKey("GradID")]
        public virtual Grade Grade { get; set; }




    }


}
