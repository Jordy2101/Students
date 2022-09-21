using Students.Application.DTOs;
using Students.Application.Filters;
using Students.Application.Paged;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students.Application.Services.Contract
{
    public interface IStudentService
    {
        PagedList<StudentDto> GetStudentsPaged(StudentsFilter filter);
    }
}
