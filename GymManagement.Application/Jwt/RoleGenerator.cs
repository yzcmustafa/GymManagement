using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManagement.Application.Jwt
{
    public class RoleGenerator
    {
        private readonly RoleManager<IdentityRole> _roleManager;
        public RoleGenerator(RoleManager<IdentityRole> roleManager)
        {
            _roleManager = roleManager;
        }

        public void CreateRole()
        {
            string[] roleNames = { "Admin", "Manager", "Trainer", "Member" };

            foreach (var role in roleNames)
            {
                var roleExist = _roleManager.RoleExistsAsync(role);

                if (!roleExist.Result)
                {
                    _roleManager.CreateAsync(new IdentityRole(role));
                }
            }
        }
    }
}
