using GymManagement.Application.Interfaces.Repositories;
using GymManagement.Domain.Entities;
using GymManagement.Infrastructure.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace GymManagement.Infrastructure.Repositories
{
    public class RepositoryBase<T> : IRepositoryBase<T> where T : BaseEntity
    {
        private readonly GymManagementDbContext _context;

        public RepositoryBase(GymManagementDbContext context)
        {
            _context = context;
        }

        public void Create(T entity)
        {
            _context.Set<T>().Add(entity);
           // _context.SaveChanges();
        }

        public void Delete(T entity)
        {
            _context.Set<T>().Remove(entity);
        }

        public List<T> Get(Expression<Func<T, bool>> filter = null)
        {
            return _context.Set<T>().Where(filter).Where(t => t.IsDeleted == false).ToList();
        }

        public List<T> GetAll()
        {
            return _context.Set<T>().Where(t=>t.IsDeleted == false).ToList();
        }

        public T GetById(int id)
        {
            return _context.Set<T>().Where(t => t.IsDeleted == false).SingleOrDefault(p => p.Id == id);
        }

        public void Update(T entity)
        {
            _context.Set<T>().Update(entity);
        }
    }
}
