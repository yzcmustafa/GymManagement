using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManagement.Application.ViewModels.CampaignViewModel
{
    public class CampaignCommandViewModel
    {
        public string CampaignName { get; set; }
        public double Price { get; set; }
        public short MonthlyPeriod { get; set; }
    }
}
