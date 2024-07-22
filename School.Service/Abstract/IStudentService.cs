using School.Data.Entities;

namespace School.Service.Abstract
{
    public interface IStudentService
    {
        Task<IQueryable<Student>> GetAllStudents();
    }
}
