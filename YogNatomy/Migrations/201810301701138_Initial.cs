namespace YogNatomy.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ClientRelationships",
                c => new
                    {
                        RelationshipId = c.Int(nullable: false, identity: true),
                        TraineeId = c.Int(nullable: false),
                        TrainerId = c.Int(nullable: false),
                        RecommendedPose = c.String(),
                        Duration = c.Int(),
                    })
                .PrimaryKey(t => t.RelationshipId);
            
            CreateTable(
                "dbo.MuscleGroups",
                c => new
                    {
                        GroupId = c.Int(nullable: false, identity: true),
                        GroupName = c.String(),
                    })
                .PrimaryKey(t => t.GroupId);
            
            CreateTable(
                "dbo.Muscles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        GroupId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.PoseClasses",
                c => new
                    {
                        ClassId = c.Int(nullable: false, identity: true),
                        ClassName = c.String(),
                    })
                .PrimaryKey(t => t.ClassId);
            
            CreateTable(
                "dbo.Poses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        PoseClass = c.String(),
                        ClassId = c.Int(nullable: false),
                        PrimaryMuscle = c.String(),
                        SecondaryMuscle = c.String(),
                        MuscleGroupId = c.Int(nullable: false),
                        FitnessLevel = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Trainees",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        TrainerId = c.Int(),
                        Height = c.Int(),
                        Weight = c.Int(),
                        Age = c.Int(),
                        FitnessLevel = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Trainers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Trainers");
            DropTable("dbo.Trainees");
            DropTable("dbo.Poses");
            DropTable("dbo.PoseClasses");
            DropTable("dbo.Muscles");
            DropTable("dbo.MuscleGroups");
            DropTable("dbo.ClientRelationships");
        }
    }
}
