﻿using AutoMapper;

namespace School.Core.Mapping.StudentMap
{
    public partial class StudentProfile : Profile
    {
        public StudentProfile()
        {
            GetAllStudentMap();
        }
    }
}
