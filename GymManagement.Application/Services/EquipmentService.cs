using AutoMapper;
using GymManagement.Application.Interfaces.ServiceInterfaces;
using GymManagement.Application.Interfaces.UnitOfWorks;
using GymManagement.Application.ViewModels.EquipmentViewModel;
using GymManagement.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManagement.Application.Services
{
    public class EquipmentService : IEquipmentService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public EquipmentService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public bool Create(EquipmentCommandViewModel model)
        {
            var equipments = _mapper.Map<Equipment>(model);

            equipments.MaintenancePeriodMounth = equipments.CreatedDate.AddMonths(model.Duration);

            _unitOfWork.Equipments.Create(equipments);
            if (_unitOfWork.SaveChanges() == true)
            {
                return true;
            }
            return false;
        }

        public bool Delete(int id)
        {
            var equipments = _unitOfWork.Equipments.GetById(id);
            equipments.IsDeleted = true;
            _unitOfWork.Equipments.Update(equipments);
            if (_unitOfWork.SaveChanges() == true)
            {
                return true;
            }
            return false;
        }

        public EquipmentQueryViewModel GetById(int id)
        {
            
            var equipments = _unitOfWork.Equipments.GetById(id);
            return _mapper.Map<EquipmentQueryViewModel>(equipments);
        }

        public List<EquipmentQueryViewModel> GetEquipmentsWithTrainer()
        {
            var equipments = _unitOfWork.Equipments.GetEquipmentsWithTrainer();
            return _mapper.Map<List<EquipmentQueryViewModel>>(equipments);
        }

        public bool Update(EquipmentCommandViewModel model, int id)
        {
            var equipments = _unitOfWork.Equipments.GetById(id);
            var eModel = _mapper.Map<Equipment>(model);
            eModel.Id = id;
            equipments.MaintenancePeriodMounth = equipments.CreatedDate.AddMonths(model.Duration);
            _unitOfWork.Equipments.Update(eModel);
            if (_unitOfWork.SaveChanges() == true)
            {
                return true;
            }
            return false;
        }
    }
}
