using FluentValidation;
using GymManagement.Application.ViewModels.EquipmentViewModel;
using GymManagement.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManagement.Application.Validations
{
    public class EquipmentValidator : AbstractValidator<EquipmentCommandViewModel>
    {
        public EquipmentValidator()
        {
            RuleFor(e => e.Name).NotEmpty().MinimumLength(3);
            RuleFor(e => e.Duration).NotEmpty().GreaterThan(Convert.ToByte(1));
        }
    }
}
