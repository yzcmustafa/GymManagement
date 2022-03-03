using GymManagement.Application.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManagement.Application.Interfaces.UnitOfWorks
{
    public interface IUnitOfWork
    {
        ICampaignRepository Campaigns { get; }
        IEmployeeDetailRepository EmployeeDetails { get; }
        IEquipmentRepository Equipments { get; }
        IExerciseProgramRepository ExercisePrograms { get; }
        IManagerRepository Managers { get; }
        IMissionRepository Missions { get; }
        ITrainerRepository Trainers { get; }
        IWorkerContractRepository WorkerContracts { get; }
        bool SaveChanges();

    }
}
