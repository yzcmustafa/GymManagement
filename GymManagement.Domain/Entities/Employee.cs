using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManagement.Domain.Entities
{
    public abstract class Employee : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string InsuranceNumber { get; set; }
        public double Salary { get; set; }
        public DateTime PaymentDate { get; set; }
    }
}
