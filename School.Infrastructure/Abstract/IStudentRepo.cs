
using School.Data.Entities;

namespace School.Infrastructure.Abstract
{
    public interface IStudentRepo : IGenericRepositoryAsync<Student>
    {
        Task<IQueryable<Student>> GetAllStudentsAsync();
    }
}
