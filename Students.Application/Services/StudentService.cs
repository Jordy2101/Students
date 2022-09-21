using Microsoft.Extensions.Options;
using Students.Application.DTOs;
using Students.Application.Services.Base;
using Students.DataAccess.Repositories.Contract;
using Students.Domain.Students;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students.Application.Services
{
    public class StudentService : ServicesBase<StudentDto>
    {
        public StudentService(IBaseRepository<StudentDto> repository ) : base(repository)
        {
        }
    }
}
