using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace GymManagement.Domain.Entities
{
    public class Trainer : BaseEntity
    {
        public int EmployeeDetailId { get; set; }
        public EmployeeDetail EmployeeDetail { get; set; }
        public List<Member> Members { get; set; }
        public int WorkerContractId { get; set; }
        public WorkerContract WorkerContract { get; set; }
        public List<Mission> Missions { get; set; }
    }
}
