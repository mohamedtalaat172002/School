using System.ComponentModel.DataAnnotations.Schema;

namespace School.Data.Entities
{
    public class Teacher
    {
        public int id { get; set; }
        public string name { get; set; }
        public double salary { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }



        //Relations
        //Teacher classRoom
        public virtual ICollection<ClassRoom> rooms { get; set; }
        //Teacher subject
        public virtual ICollection<Subject> subjects { get; set; }
        // teacher Department
        public int Did { get; set; }
        [ForeignKey("Did")]
        public Department Department { get; set; }

    }
}
