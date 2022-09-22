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
    public class EmailValidate : AbstractValidator<Student>
    {
        public EmailValidate()
        {
            RuleFor(x => x.Email).NotEmpty().WithMessage(MessageCodes.MessageCodes.FieldEmpty("Email"))
                                 .Length(5, 40).WithMessage(MessageCodes.MessageCodes.FieldExcess(5, 40, "Email"));
        }
    }
}
