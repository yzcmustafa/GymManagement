using GymManagement.Application.Interfaces.Repositories;
using GymManagement.Infrastructure.Repositories;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManagement.Infrastructure.DependencyContainer
{
    public static class DependencyContainer
    {
        public static void AddInfrastructure(this IServiceCollection services)
        {
            services.AddScoped<ICampaignRepository, CampaignRepository>();
        }
    }
}
