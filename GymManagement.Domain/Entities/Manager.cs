using System;
using System.Collections.Generic;

namespace GymManagement.Domain.Entities
{
    public class Manager : BaseEntity
    {
        public int EmployeeDetailId { get; set; }
        public EmployeeDetail EmployeeDetail { get; set; }
        public List<Trainer> Trainers { get; set; }
    }
}
