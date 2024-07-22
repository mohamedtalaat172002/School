using Microsoft.EntityFrameworkCore;
using School.Data.Entities;
using School.Infrastructure.Abstract;
using School.Infrastructure.Context;

namespace School.Infrastructure.Implementaion
{
    public class StudentRepo : GenericRepositoryAsync<Student>, IStudentRepo
    {
        private readonly DbSet<Student> students;
        public StudentRepo(ApplicationDbContext dbContext) : base(dbContext)
        {
            students = dbContext.Set<Student>();
        }

        public async Task<IQueryable<Student>> GetAllStudentsAsync()
        {
            return students
            .Include(s => s.Department)
            .Include(s => s.Grade)
            .Include(s => s.ClassRoom);


        }
    }
}
