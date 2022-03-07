using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManagement.Application.ViewModels.MemberViewModel
{
    public class MemberRegisterViewModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool IsPaymentStatus { get; set; }
        public int ExerciseProgramId { get; set; }
        public int CampaignId { get; set; }
    }
}
