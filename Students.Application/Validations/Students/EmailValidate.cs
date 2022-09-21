using FluentValidation;
using Students.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students.Application.Validations.Students
{
    public class EmailValidate : AbstractValidator<StudentDto>
    {
        public EmailValidate()
        {
            RuleFor(x => x.Email).Empty().WithMessage(MessageCodes.MessageCodes.FieldEmpty("Email"))
                                 .Length(5, 40).WithMessage(MessageCodes.MessageCodes.FieldExcess(5, 40));
        }
    }
}
