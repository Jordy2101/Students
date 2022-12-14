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
    public class AgeValidate : AbstractValidator<Student>
    {
        public AgeValidate()
        {
            RuleFor(x => x.Age).NotEqual(0).WithMessage(MessageCodes.MessageCodes.FieldEmpty("Age"));
        }
    }
}
