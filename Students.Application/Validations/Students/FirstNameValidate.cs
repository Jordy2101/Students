using FluentValidation;
using Students.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students.Application.Validations.Students
{
    public class FirstNameValidate : AbstractValidator<StudentDto>
    {
        public FirstNameValidate()
        {
            RuleFor(x => x.FirstName).Empty().WithMessage(MessageCodes.MessageCodes.FieldEmpty("FirstName"))
                                     .Length(5, 40).WithMessage(MessageCodes.MessageCodes.FieldExcess(5, 40));
        }
    }
}
