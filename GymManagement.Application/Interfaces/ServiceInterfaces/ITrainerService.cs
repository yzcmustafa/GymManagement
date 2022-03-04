using GymManagement.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManagement.Application.Interfaces.ServiceInterfaces
{
    public interface ITrainerService
    {
        List<Trainer> GetAll();
        bool AddMemberExerciseProgram(int memberId);
        bool EquipmentMaintenanceControl(int equipmentId);
    }
}
