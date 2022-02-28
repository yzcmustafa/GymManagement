using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace GymManagement.Domain.Entities
{
    public class Trainer : Worker
    {
        public List<Member> Members { get; set; }
    }
}
