using FluentValidation;
using GymManagement.Application.ViewModels.ExerciseProgramViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManagement.Application.Validations
{
    public class ExerciseProgramValidator : AbstractValidator<ExerciseCommandViewModel>
    {
        public ExerciseProgramValidator()
        {
            RuleFor(e => e.ProgramName).NotEmpty();
            RuleFor(e => e.Period).NotNull();
        }
    }
}
