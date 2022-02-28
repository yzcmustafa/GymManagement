using System;

namespace GymManagement.Domain.Entities
{
    public class Equipment
    {
        public string Name { get; set; }
        public DateTime MaintenancePeriod { get; set; }
        public byte Duration { get; set; }
        public bool IsActive { get; set; }
        public int TrainerId { get; set; }
        public Trainer Trainer { get; set; }
    }
}
