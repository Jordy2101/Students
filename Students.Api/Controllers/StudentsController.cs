using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Students.Api.Infraestructure;
using Students.Application.DTOs;
using Students.Application.Filters;
using Students.Application.Services.Base;
using Students.Application.Services.Base.Contract;
using Students.Application.Services.Contract;
using Students.Domain.Students;

namespace Students.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : BaseApiController<Student, StudentDto, IServicesBase<Student>>
    {
        public readonly IStudentService _service;
        public StudentsController(IServicesBase<Student> manager, IMapper mapper, IStudentService service) : base(manager, mapper)
        {
            _service = service;
        }

        [HttpGet]
        [Route("GetStudentsPaged")]
        public IActionResult GetStudentsPaged([FromQuery] StudentsFilter filter)
        {
            try
            {
                return Ok(_service.GetStudentsPaged(filter));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
