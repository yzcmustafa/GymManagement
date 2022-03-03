using GymManagement.Application.ViewModels.EquipmentViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManagement.Application.Interfaces.ServiceInterfaces
{
    public interface IEquipmentService
    {
        EquipmentQueryViewModel GetById(int id);
        public List<EquipmentQueryViewModel> GetEquipmentsWithTrainer();
        bool Create(EquipmentCommandViewModel model); // kullanıcıyanın değiştirebeileceği entityler için query
        bool Update(EquipmentCommandViewModel model, int id);
        bool Delete(int id);
    }
}
