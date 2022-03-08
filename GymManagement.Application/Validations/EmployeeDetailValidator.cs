using FluentValidation;
using GymManagement.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManagement.Application.Validations
{
    public class EmployeeDetailValidator : AbstractValidator<EmployeeDetail>
    {
        public EmployeeDetailValidator()
        {
            RuleFor(e => e.FirstName).NotEmpty().MinimumLength(2);
            RuleFor(e => e.LastName).NotEmpty().MinimumLength(2);
            RuleFor(e => e.InsuranceNumber).NotEmpty().Length(11);
            RuleFor(e => e.Salary).NotEmpty().GreaterThanOrEqualTo(4200);
        }
    }
}
