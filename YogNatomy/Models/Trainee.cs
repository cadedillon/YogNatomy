using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace YogNatomy.Models
{
    public class Trainee
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int? TrainerId { get; set; }
        public int? Height { get; set; }
        public int? Weight { get; set; }
        public int? Age { get; set; }
        public int FitnessLevel { get; set; }

    }
}