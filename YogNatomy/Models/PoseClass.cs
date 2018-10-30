using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace YogNatomy.Models
{
    public class PoseClass
    {
        [Key]
        public int ClassId { get; set; }
        public string ClassName { get; set; }
    }
}