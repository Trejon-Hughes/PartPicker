namespace PartPicker.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FinishedMotherboard : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Motherboard", "MotherboardModel", c => c.String(nullable: false));
            AlterColumn("dbo.Motherboard", "MotherboardFormFactor", c => c.Int(nullable: false));
            AlterColumn("dbo.Motherboard", "RAMType", c => c.Int(nullable: false));
            DropColumn("dbo.Motherboard", "Model");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Motherboard", "Model", c => c.String(nullable: false));
            AlterColumn("dbo.Motherboard", "RAMType", c => c.String(nullable: false));
            AlterColumn("dbo.Motherboard", "MotherboardFormFactor", c => c.String(nullable: false));
            DropColumn("dbo.Motherboard", "MotherboardModel");
        }
    }
}
