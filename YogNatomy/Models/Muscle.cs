//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace YogNatomy.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Muscle
    {
        public int muscleid { get; set; }
        public string musclename { get; set; }
        public int musclegroupid { get; set; }
    
        public virtual MuscleGroup MuscleGroup { get; set; }
    }
}
