namespace School.Data.Entities
{

    public enum year
    {
        First = 1,
        Seconed,
        Third,
        Fourth,
        Fifth,
        Sixth

    }
    public class Grade
    {
        //الي هي صف يعني صف خامس صف سادس كده يعني 
        public int id { get; set; }
        public year year { get; set; }
        //Relations
        //Subjet Grad
        public virtual ICollection<Subject> Subjects { get; set; }
        //StudentGrad
        public virtual ICollection<Student> students { get; set; }
    }
}
