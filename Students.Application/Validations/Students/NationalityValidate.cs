using FluentValidation;
using Students.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students.Application.Validations.Students
{
    public class NationalityValidate : AbstractValidator<StudentDto>
    {
        public NationalityValidate()
        {
            RuleFor(x => x.Nationality).Empty().WithMessage(MessageCodes.MessageCodes.FieldEmpty("Nationality"))
                                       .Length(5, 40).WithMessage(MessageCodes.MessageCodes.FieldExcess(5, 40));
        }
    }
}
