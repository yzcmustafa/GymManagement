using System;

namespace GymManagement.Domain.Entities
{
    public class Equipment : BaseEntity
    {
        public string Name { get; set; }
        public DateTime MaintenancePeriodMounth { get; set; }
        public byte Duration { get; set; }
        public bool IsActive { get; set; }
        public int TrainerId { get; set; }
        public Trainer Trainer { get; set; }
    }
}
