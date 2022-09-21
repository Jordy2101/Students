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
    public class StudentIsOver18 : AbstractValidator<Student>
    {
        public StudentIsOver18()
        {
            RuleFor(x => x.DateOfBirth).Must(IsOver18).WithMessage("You must be of legal age to register.");
        }
        private bool IsOver18(DateTime birthDate)
        {
            return DateTime.Now.AddYears(-18) >= birthDate;
        }
    }
}
