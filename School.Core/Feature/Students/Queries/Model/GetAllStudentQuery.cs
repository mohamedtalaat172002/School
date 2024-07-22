using MediatR;
using School.Core.Base;
using School.Core.Feature.Students.Queries.Result;

namespace School.Core.Feature.Students.Queries.Model
{
    public class GetAllStudentQuery : IRequest<Response<IQueryable<GetAllStudentDto>>>
    {
    }
}
