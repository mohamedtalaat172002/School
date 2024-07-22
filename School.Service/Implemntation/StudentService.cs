using School.Data.Entities;
using School.Infrastructure.Abstract;
using School.Service.Abstract;

namespace School.Service.Implemntation
{
    public class StudentService : IStudentService
    {
        private readonly IStudentRepo _studentRepo;
        public StudentService(IStudentRepo studentRepo)
        {
            this._studentRepo = studentRepo;
        }
        public async Task<IQueryable<Student>> GetAllStudents()
        {
            var students = await _studentRepo.GetAllStudentsAsync();
            return students;
        }
    }
}
