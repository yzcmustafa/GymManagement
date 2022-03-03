using GymManagement.Application.ViewModels.EquipmentViewModel;
using GymManagement.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManagement.Application.Interfaces.Repositories
{
    public interface IEquipmentRepository : IRepositoryBase<Equipment>
    {
        public List<Equipment> GetEquipmentsWithTrainer();
    }
}
