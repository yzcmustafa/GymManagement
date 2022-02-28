using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManagement.Domain.Entities
{
    public class Worker : Employee
    {
        public int WorkerContractId { get; set; }
        public WorkerContract WorkerContract { get; set; }
        public List<Mission> Missions { get; set; }
    }
}
