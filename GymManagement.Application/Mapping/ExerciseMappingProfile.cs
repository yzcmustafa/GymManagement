using AutoMapper;
using GymManagement.Application.ViewModels.CampaignViewModel;
using GymManagement.Application.ViewModels.ExerciseProgramViewModel;
using GymManagement.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManagement.Application.Mapping
{
    public class ExerciseMappingProfile :Profile
    {
        public ExerciseMappingProfile()
        {
            CreateMap<ExerciseProgram, ExerciseQueryViewModel>().ReverseMap();
            CreateMap<Campaign, ExerciseCommandViewModel>().ReverseMap();
        }   
    }
}
