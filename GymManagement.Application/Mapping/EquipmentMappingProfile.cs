using AutoMapper;
using GymManagement.Application.ViewModels.EquipmentViewModel;
using GymManagement.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManagement.Application.Mapping
{
    class EquipmentMappingProfile : Profile
    {
        public EquipmentMappingProfile()
        {
            CreateMap<Equipment, EquipmentQueryViewModel>().ReverseMap();
        }
    }
}
