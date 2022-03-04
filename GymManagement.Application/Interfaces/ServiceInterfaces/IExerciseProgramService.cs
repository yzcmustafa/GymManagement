using GymManagement.Application.ViewModels.CampaignViewModel;
using GymManagement.Application.ViewModels.ExerciseProgramViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManagement.Application.Interfaces.ServiceInterfaces
{
    public interface IExerciseProgramService
    {
        ExerciseQueryViewModel GetById(int id);
        List<ExerciseQueryViewModel> GetAll(); // kullanıcıya gösterilecek entityler için query
        bool Create(ExerciseCommandViewModel model); // kullanıcıyanın değiştirebeileceği entityler için query
        bool Update(ExerciseCommandViewModel model, int id);
        bool Delete(int id);
    }
}
