using AutoMapper;
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

        public bool Update(CampaignCommandViewModel model, int id)
        {
            var campaing = _unitOfWork.Campaigns.GetById(id);
            if (campaing == null)
            {
                throw new InvalidOperationException("Campaign is not found");
            }
            var vmModel = _mapper.Map<Campaign>(model);
            vmModel.Id = id;
            _unitOfWork.Campaigns.Update(vmModel);
            if (_unitOfWork.SaveChanges() == true)
            {
                return true;
            }
            return false;
        }

        public bool Delete(int id)
        {
            var campaign = _unitOfWork.Campaigns.GetById(id);
            if (campaign == null)
            {
                throw new InvalidOperationException("Campaign is not found");
            }
            campaign.IsDeleted = true;
            _unitOfWork.Campaigns.Update(campaign);
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
