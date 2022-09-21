using FluentValidation;
using Students.Application.DTOs;
using Students.Domain.Students;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students.Application.Validations.Students
{
    public class StudentsValidations : AbstractValidator<Student>
    {
        public StudentsValidations()
        {
            Include(new StudentIsOver18());
            Include(new FirstNameValidate());
            Include(new LastNameValidate());
            Include(new EmailValidate());
            Include(new NationalityValidate());
            Include(new AgeValidate());
        }
    }
}
