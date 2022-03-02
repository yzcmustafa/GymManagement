using GymManagement.Application.Interfaces.Repositories;
using GymManagement.Domain.Entities;
using GymManagement.Infrastructure.Contexts;

namespace GymManagement.Infrastructure.Repositories
{
    public class EmployeeDetailRepository : RepositoryBase<EmployeeDetail>, IEmployeeDetailRepository
    {
        public EmployeeDetailRepository(GymManagementDbContext context) : base(context)
        {
        }
    }
}
