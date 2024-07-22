using Microsoft.AspNetCore.Mvc;
using School.Core.Feature.Students.Queries.Model;
using School.Data.AppMetaData;
using SchoolApi.Base;

namespace SchoolApi.Controllers
{
    public class StudentController : AppController
    {
        [HttpGet(Router.StudentRouting.List)]
        public async Task<IActionResult> Getstudents()
        {
            var res = await mediator.Send(new GetAllStudentQuery());
            return Ok(res);
        }
    }
}
