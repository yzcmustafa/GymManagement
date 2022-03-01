using System.Collections.Generic;

namespace GymManagement.Domain.Entities
{
    public class ExerciseProgram : BaseEntity
    {
        public string ProgramName { get; set; }
        public short Period { get; set; }
        public List<Member> Members { get; set; }
        public int TrainerId { get; set; }
        public Trainer Trainer { get; set; }
    }
}
