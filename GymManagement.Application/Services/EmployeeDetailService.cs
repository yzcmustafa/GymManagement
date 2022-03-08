using AutoMapper;
using FluentValidation;
using GymManagement.Application.Interfaces.ServiceInterfaces;
using GymManagement.Application.Interfaces.UnitOfWorks;
using GymManagement.Application.Validations;
using GymManagement.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManagement.Application.Services
{
    class EmployeeDetailService : IEmployeeDetailService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public EmployeeDetailService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public bool Create(EmployeeDetail model)
        {
            var validator = new EmployeeDetailValidator();
            validator.ValidateAndThrow(model);

            _unitOfWork.EmployeeDetails.Create(model);
            if (_unitOfWork.SaveChanges() == true)
            {
                return true;
            }
            return false;
        }

        public bool Delete(int id)
        {
            var employeeDetail = _unitOfWork.EmployeeDetails.GetById(id);
            employeeDetail.IsDeleted = true;
            _unitOfWork.EmployeeDetails.Update(employeeDetail);
            if (_unitOfWork.SaveChanges() == true)
            {
                return true;
            }
            return false;
        }

        public EmployeeDetail GetById(int id)
        {
            return _unitOfWork.EmployeeDetails.GetById(id);
        }

        public bool Update(EmployeeDetail model, int id)
        {
            var validator = new EmployeeDetailValidator();
            validator.ValidateAndThrow(model);

            var employeeDetail = _unitOfWork.EmployeeDetails.GetById(id);
            _unitOfWork.EmployeeDetails.Update(model);

            if (_unitOfWork.SaveChanges() == true)
            {
                return true;
            }
            return false;
        }
    }
}
