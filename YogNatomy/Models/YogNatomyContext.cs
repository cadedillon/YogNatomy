using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace YogNatomy.Models
{
    public class YogNatomyContext : DbContext
    {
        public YogNatomyContext() : base("YogNatomyContext")
        {}

        public DbSet<Pose> Poses { get; set; }
        public DbSet<Trainee> Trainees { get; set; }
        public DbSet<Trainer> Trainers { get; set; }
        public DbSet<Muscle> Muscles { get; set; }
        public DbSet<PoseClass> PoseClasses { get; set; }
        public DbSet<MuscleGroup> MuscleGroups { get; set; }
        public DbSet<ClientRelationship> ClientRelationships { get; set; }
    }
}