using AutoMapper;
using GymManagement.Application.Interfaces.ServiceInterfaces;
using GymManagement.Application.Jwt;
using GymManagement.Application.ViewModels.MemberViewModel;
using GymManagement.Domain.Entities;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManagement.Application.Services
{
    public class AuthService : IAuthService
    {
        private readonly UserManager<Member> _userManager;
        private readonly IMapper _mapper;
        private readonly SignInManager<Member> _signInManager;
        private readonly TokenGenerator _tokenGenerator;
        private readonly RoleGenerator _roleGenerator;

        public AuthService(UserManager<Member> userManager, IMapper mapper, SignInManager<Member> signInManager, TokenGenerator tokenGenerator, RoleGenerator roleGenerator)
        {
            _userManager = userManager;
            _mapper = mapper;
            _signInManager = signInManager;
            _tokenGenerator = tokenGenerator;
            _roleGenerator = roleGenerator;
        }


        public async Task<Token> Login(MemberLoginViewModel loginViewModel)
        {
            var memberFind = await _userManager.FindByEmailAsync(loginViewModel.Email);
            if (memberFind is null)
            {
                throw new InvalidOperationException("Email bulunamadı");
            }
            var result = await _userManager.CheckPasswordAsync(memberFind, loginViewModel.Password);
            if (!result)
            {
                throw new InvalidOperationException("Şifre yalnış.");
            }
            var userRoles = await _userManager.GetRolesAsync(memberFind);

            var token = _tokenGenerator.CreateToken(memberFind, userRoles.ToList());
            return token;
        }

        public async Task<bool> Register(MemberRegisterViewModel registerViewModel)
        {
            var member = _mapper.Map<Member>(registerViewModel);

            var emailCheckMember = await _userManager.FindByIdAsync(registerViewModel.Email);

            if (emailCheckMember is not null)
                throw new InvalidOperationException("Email Mevcut");

            var result = await _userManager.CreateAsync(member, registerViewModel.Password);

            _roleGenerator.CreateRole();

            if (result.Succeeded)
            {
                await _userManager.AddToRoleAsync(member, "Member");
                await _signInManager.SignInAsync(member, false);
                return true;
            }
            throw new InvalidOperationException("Kullanıcı kaydı gerçekleştirilemedi.");
        }
    }
}
