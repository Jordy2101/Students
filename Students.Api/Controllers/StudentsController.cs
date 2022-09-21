using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Students.Api.Infraestructure;
using Students.Application.DTOs;
using Students.Application.Services.Base;
using Students.Application.Services.Base.Contract;
using Students.Domain.Students;

namespace Students.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : BaseApiController<Student, StudentDto, IServicesBase<Student>>
    {
        public StudentsController(IServicesBase<Student> manager, IMapper mapper) : base(manager, mapper)
        {
        }
    }
}
