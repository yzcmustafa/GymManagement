using GymManagement.Application.Interfaces.Repositories;
using GymManagement.Domain.Entities;
using GymManagement.Infrastructure.Contexts;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace GymManagement.Infrastructure.Repositories
{
    public class ManagerRepository : RepositoryBase<Manager>, IManagerRepository
    {
        private readonly GymManagementDbContext _context;
        public ManagerRepository(GymManagementDbContext context) : base(context)
        {
            _context = context;
        }

        public bool AddMissionToTrainer(int missionId, int trainerId)
        {
            var trainer = _context.Trainers.Include(t => t.Missions).SingleOrDefault(t => t.Id == trainerId);
            var mission = _context.Missions.SingleOrDefault(m => m.Id == missionId);

            trainer.Missions.Add(mission);
            return _context.SaveChanges() > 0;
        }
    }
}
