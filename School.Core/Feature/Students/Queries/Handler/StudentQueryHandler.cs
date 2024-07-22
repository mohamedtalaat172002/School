using AutoMapper;
using MediatR;
using School.Core.Base;
using School.Core.Feature.Students.Queries.Model;
using School.Core.Feature.Students.Queries.Result;
using School.Service.Abstract;

namespace School.Core.Feature.Students.Queries.Handler
{
    public class StudentQueryHandler : ResponseHandler
        , IRequestHandler<GetAllStudentQuery, Response<IQueryable<GetAllStudentDto>>>
    {
        private readonly IStudentService _studentService;
        private readonly IMapper _mapper;
        public StudentQueryHandler(IStudentService studentService, IMapper mapper)
        {
            _studentService = studentService;
            _mapper = mapper;
        }

        public async Task<Response<IQueryable<GetAllStudentDto>>> Handle(GetAllStudentQuery request, CancellationToken cancellationToken)
        {
            var StudentsList = await _studentService.GetAllStudents();
            var StudentListMapped = _mapper.Map<IEnumerable<GetAllStudentDto>>(StudentsList).AsQueryable();
            return Success(StudentListMapped);
        }
    }
}
