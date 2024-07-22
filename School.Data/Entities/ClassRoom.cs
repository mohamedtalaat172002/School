using System.ComponentModel.DataAnnotations.Schema;

namespace School.Data.Entities
{
    public class ClassRoom
    {
        public int Id { get; set; }
        public String Location { get; set; }

        //relations 
        //Student classRoom
        public ICollection<Student> Students { get; set; }

        // Teacher ClassRoom
        public ICollection<Teacher> Teachers { get; set; }
        //Department ClassRoom
        public int Did { get; set; }
        [ForeignKey("Did")]
        public virtual Department Department { get; set; }
    }
}
