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
    
    public partial class Pose
    {
        public int poseid { get; set; }
        public string posename { get; set; }
        public string poseclass { get; set; }
        public int classid { get; set; }
        public string primarymuscles { get; set; }
        public string secondarymuscles { get; set; }
        public int musclegroupid { get; set; }
        public int fitnesslevel { get; set; }
    
        public virtual MuscleGroup MuscleGroup { get; set; }
        public virtual PoseClass PoseClass1 { get; set; }
    }
}
