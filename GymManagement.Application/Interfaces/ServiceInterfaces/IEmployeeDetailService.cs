using GymManagement.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManagement.Application.Interfaces.ServiceInterfaces
{
    interface IEmployeeDetailService
    {
        EmployeeDetail GetById(int id);
        bool Create(EmployeeDetail model);
        bool Update(EmployeeDetail model, int id);
        bool Delete(int id);
    }
}
