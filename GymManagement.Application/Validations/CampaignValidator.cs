using FluentValidation;
using GymManagement.Application.ViewModels.CampaignViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManagement.Application.Validations
{
    public class CampaignValidator : AbstractValidator<CampaignCommandViewModel>
    {
        public CampaignValidator()
        {
            RuleFor(c => c.CampaignName).NotEmpty().MinimumLength(3);
            RuleFor(c => c.Price).GreaterThan(0);
            RuleFor(c => c.MonthlyPeriod).GreaterThan(Convert.ToInt16(0));
        }
    }
}
