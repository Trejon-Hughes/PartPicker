namespace PartPicker.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UserBuilds : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.UserBuild",
                c => new
                    {
                        BuildID = c.Int(nullable: false, identity: true),
                        BuildCreator = c.Guid(nullable: false),
                        MotherboardID = c.Int(nullable: false),
                        CPUID = c.Int(nullable: false),
                        GPUID = c.Int(nullable: false),
                        RAMID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.BuildID)
                .ForeignKey("dbo.CPU", t => t.CPUID, cascadeDelete: true)
                .ForeignKey("dbo.GPU", t => t.GPUID, cascadeDelete: true)
                .ForeignKey("dbo.Motherboard", t => t.MotherboardID, cascadeDelete: true)
                .ForeignKey("dbo.RAM", t => t.RAMID, cascadeDelete: true)
                .Index(t => t.MotherboardID)
                .Index(t => t.CPUID)
                .Index(t => t.GPUID)
                .Index(t => t.RAMID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UserBuild", "RAMID", "dbo.RAM");
            DropForeignKey("dbo.UserBuild", "MotherboardID", "dbo.Motherboard");
            DropForeignKey("dbo.UserBuild", "GPUID", "dbo.GPU");
            DropForeignKey("dbo.UserBuild", "CPUID", "dbo.CPU");
            DropIndex("dbo.UserBuild", new[] { "RAMID" });
            DropIndex("dbo.UserBuild", new[] { "GPUID" });
            DropIndex("dbo.UserBuild", new[] { "CPUID" });
            DropIndex("dbo.UserBuild", new[] { "MotherboardID" });
            DropTable("dbo.UserBuild");
        }
    }
}
