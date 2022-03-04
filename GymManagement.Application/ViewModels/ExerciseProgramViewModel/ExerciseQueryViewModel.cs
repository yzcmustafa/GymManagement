using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManagement.Application.ViewModels.ExerciseProgramViewModel
{
    public class ExerciseQueryViewModel
    {
        public int Id { get; set; }
        public string ProgramName { get; set; }
        public short Period { get; set; }
        public int TrainerId { get; set; }
    }
}
