using GymManagement.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManagement.Application.ViewModels.EquipmentViewModel
{
    public class EquipmentCommandViewModel
    {
        public string Name { get; set; }
        //public DateTime MaintenancePeriodMounth { get; set; }
        public byte Duration { get; set; }
        public bool IsActive { get; set; }
    }
}
