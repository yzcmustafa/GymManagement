using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace GymManagement.Domain.Entities
{
    public class Trainer : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string InsuranceNumber { get; set; }
        public double Salary { get; set; }
        public DateTime PaymentDate { get; set; }
        [ForeignKey("Worker")]
        public int WorkerId { get; set; }
        // public Worker Worker { get; set; } // attiribute veya bu şekilde tanımlayabiliriz.
        public int WorkerContractId { get; set; }
        public WorkerContract WorkerContract { get; set; }
        public List<Member> Members { get; set; }
        public List<Mission> Missions { get; set; }

    }
}
