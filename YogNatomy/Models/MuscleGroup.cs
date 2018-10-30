using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace YogNatomy.Models
{
    public class MuscleGroup
    {
        [Key]
        public int GroupId { get; set; }
        public string GroupName { get; set; }
    }
}