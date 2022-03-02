﻿using AutoMapper;
using GymManagement.Application.Interfaces.Repositories;
using GymManagement.Application.Interfaces.ServiceInterfaces;
using GymManagement.Application.Interfaces.UnitOfWorks;
using GymManagement.Application.ViewModels.CampaignViewModel;
using GymManagement.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManagement.Application.Services
{
    public class CampaignService : ICampignService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public CampaignService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public bool Create(CampaignCommandViewModel model)
        {
            var campaing = _mapper.Map<Campaign>(model);
            _unitOfWork.Campaigns.Create(campaing);
            if (_unitOfWork.SaveChanges() == true)
            {
                return true;
            }
            return false;
        }

        public bool Delete(CampaignCommandViewModel model)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            var campaign = _unitOfWork.Campaigns.GetById(id);
            _unitOfWork.Campaigns.Delete(campaign);
            if (_unitOfWork.SaveChanges() == true)
            {
                return true;
            }
            return false;
        }

        public List<CampaignQueryViewModel> GetAll()
        {
            var campaigns = _unitOfWork.Campaigns.GetAll();
            return _mapper.Map<List<CampaignQueryViewModel>>(campaigns);
        }

        public CampaignQueryViewModel GetById(int id)
        {
            var campaign =_unitOfWork.Campaigns.GetById(id);
            return _mapper.Map<CampaignQueryViewModel>(campaign);
        }
    }
}
