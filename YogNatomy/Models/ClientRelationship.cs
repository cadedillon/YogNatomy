using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace YogNatomy.Models
{
    public class ClientRelationship
    {
        [Key]
        public int RelationshipId { get; set; }
        public int TraineeId { get; set; }
        public int TrainerId { get; set; }
        public string RecommendedPose { get; set; }
        public int? Duration { get; set; }
    }
}