using GymManagement.Application.ViewModels.CampaignViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManagement.Application.Interfaces.ServiceInterfaces
{
    interface ICampignService
    {
        CampaignQueryViewModel GetById(int id);
        List<CampaignQueryViewModel> GetAll(); // kullanıcıya gösterilecek entityler için query
        bool Create(CampaignCommandViewModel model); // kullanıcıyanın değiştirebeileceği entityler için query
        bool Update(CampaignCommandViewModel model, int id);
        bool Delete(int id);
    }
}
