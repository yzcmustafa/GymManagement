using GymManagement.Application.ViewModels.MemberViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManagement.Application.Interfaces.ServiceInterfaces
{
    public interface IAuthService
    {
        Task<bool> Register(MemberRegisterViewModel registerViewModel);
        Task<Token> Login(MemberLoginViewModel loginViewModel);
    }
}
