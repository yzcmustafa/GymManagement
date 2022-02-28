using System;

namespace GymManagement.Domain.Entities
{
    public class WorkerContract : BaseEntity
    {
        public DateTime EndDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public short Duration { get; set; }
        public bool IsActive { get; set; }
        public Worker Worker { get; set; }
        public Trainer Trainer { get; set; }
    }
}
