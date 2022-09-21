using AutoMapper;
using FluentValidation;
using FluentValidation.Results;
using Microsoft.Extensions.Options;
using Students.Application.DTOs;
using Students.Application.Filters;
using Students.Application.Paged;
using Students.Application.Services.Base;
using Students.Application.Services.Contract;
using Students.Application.Validations.Students;
using Students.DataAccess.Repositories.Contract;
using Students.Domain.Students;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students.Application.Services
{
    public class StudentService : ServicesBase<Student>, IStudentService
    {
        protected readonly IMapper _Mapper;
        public StudentService(IBaseRepository<Student> repository, IMapper mapper) : base(repository)
        {
            _Mapper = mapper;
        }

        public override int Create(Student entity)
        {
            var validator = new StudentsValidations();

            var result = validator.Validate(entity);

            if (!result.IsValid)
            {
                foreach (var failure in result.Errors)
                {
                    if (failure.CustomState is Exception ex)
                    {
                        throw ex;
                    }
                }
            }
            return base.Create(entity);
        }

        public PagedList<StudentDto> GetStudentsPaged(StudentsFilter filter)
        {
            try
            {
                var data = base.FindAll();

                data = !data.Any() ? throw new ArgumentException(MessageCodes.MessageCodes.EmptyCollections) : data;

                data = filter.keywrod is not null ? data.Where(c=> c.FirstName.Contains(filter.keywrod) || c.LastName.Contains(filter.keywrod)
                                                               || c.Nationality.Contains(filter.keywrod) || c.Email.Contains(filter.keywrod)) : data;

                data = !data.Any()? throw new ArgumentException(MessageCodes.MessageCodes.EmptyCollections) : data;

                var mapEntity = _Mapper.Map<IQueryable<StudentDto>>(data);

                var pagelist = PagedList<StudentDto>.Create(mapEntity, filter.PageNumber, filter.PageSize);

                return pagelist;
            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }
        }
    }
}
