using FluentValidation;
using Students.Application.DTOs;
using Students.Domain.Students;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Students.Application.Validations.Students
{
    public class LastNameValidate : AbstractValidator<Student>
    {
        public LastNameValidate()
        {
            RuleFor(x => x.LastName).NotEmpty().WithMessage(MessageCodes.MessageCodes.FieldEmpty("LastName"))
                                    .Length(5, 40).WithMessage(MessageCodes.MessageCodes.FieldExcess(2, 40, "LastName"))
                                    .NotEqual(x => x.FirstName).WithName("The First Name must be different from the LastName");
        }
    }
}
