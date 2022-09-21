using FluentValidation;
using Students.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students.Application.Validations.Students
{
    public class AgeValidate : AbstractValidator<StudentDto>
    {
        public AgeValidate()
        {
            RuleFor(x => x.Age).Equal(0).WithMessage(MessageCodes.MessageCodes.FieldEmpty("Age"));
        }
    }
}
