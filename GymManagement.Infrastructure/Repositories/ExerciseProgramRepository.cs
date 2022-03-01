using GymManagement.Application.Interfaces.Repositories;
using GymManagement.Domain.Entities;
using GymManagement.Infrastructure.Contexts;

namespace GymManagement.Infrastructure.Repositories
{
    public class ExerciseProgramRepository : RepositoryBase<ExerciseProgram>, IExerciseProgramRepository
    {
        public ExerciseProgramRepository(GymManagementDbContext context) : base(context)
        {
        }
    }
}
