using School.Core.Feature.Students.Queries.Result;
using School.Data.Entities;


namespace School.Core.Mapping.StudentMap
{
    public partial class StudentProfile
    {
        public void GetAllStudentMap()
        {
            CreateMap<Student, GetAllStudentDto>().
                ForMember(dest => dest.DepartmentName, opt => opt.MapFrom(s => s.Department.DName)).
                ForMember(dest => dest.ClassRoomLocation, src => src.MapFrom(s => s.ClassRoom.Location))
               .ForMember(dest => dest.Gradyear, src => src.MapFrom(s => s.Grade.year.ToString()));


        }
    }
}

