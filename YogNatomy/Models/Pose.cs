using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace YogNatomy.Models
{
    public class Pose 
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Class { get; set; }
        public int ClassId { get; set; }
        public string PrimaryMuscle { get; set; }
        public string SecondaryMuscle { get; set; }
        public int FitnessLevel { get; set; }
    }
}