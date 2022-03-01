using GymManagement.Application.Interfaces.Repositories;
using GymManagement.Domain.Entities;
using GymManagement.Infrastructure.Contexts;

namespace GymManagement.Infrastructure.Repositories
{
    public class WorkerContractRepository : RepositoryBase<WorkerContract>, IWorkerContractRepository
    {
        public WorkerContractRepository(GymManagementDbContext context) : base(context)
        {
        }
    }
}
