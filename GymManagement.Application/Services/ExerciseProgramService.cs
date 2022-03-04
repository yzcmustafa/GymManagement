using AutoMapper;
using GymManagement.Application.Interfaces.ServiceInterfaces;
using GymManagement.Application.Interfaces.UnitOfWorks;
using GymManagement.Application.ViewModels.ExerciseProgramViewModel;
using GymManagement.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManagement.Application.Services
{
    public class ExerciseProgramService : IExerciseProgramService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public ExerciseProgramService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public bool Create(ExerciseCommandViewModel model)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            var exercise = _unitOfWork.ExercisePrograms.GetById(id);
            if (exercise == null)
            {
                throw new InvalidOperationException("exercise is not found");
            }
            exercise.IsDeleted = true;
            _unitOfWork.ExercisePrograms.Update(exercise);
            if (_unitOfWork.SaveChanges() == true)
            {
                return true;
            }
            return false;
        }

        public List<ExerciseQueryViewModel> GetAll()
        {
            var exercise = _unitOfWork.ExercisePrograms.GetAll();
            return _mapper.Map<List<ExerciseQueryViewModel>>(exercise);
        }

        public ExerciseQueryViewModel GetById(int id)
        {
            var exercise = _unitOfWork.Campaigns.GetById(id);
            return _mapper.Map<ExerciseQueryViewModel>(exercise);
        }

        public bool Update(ExerciseCommandViewModel model, int id)
        {
            var exercise = _unitOfWork.ExercisePrograms.GetById(id);
            if (exercise == null)
            {
                throw new InvalidOperationException("Campaign is not found");
            }
            var exModel = _mapper.Map<ExerciseProgram>(model);
            exModel.Id = id;
            _unitOfWork.ExercisePrograms.Update(exModel);
            if (_unitOfWork.SaveChanges() == true)
            {
                return true;
            }
            return false;
        }
    }
}
