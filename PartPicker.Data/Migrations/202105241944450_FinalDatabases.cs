namespace PartPicker.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FinalDatabases : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CPU",
                c => new
                    {
                        CPUID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Brand = c.String(),
                        CPUModel = c.String(),
                        SocketType = c.String(),
                        CoreName = c.String(),
                        NumberOfCores = c.Int(nullable: false),
                        NumberOfThreads = c.Int(nullable: false),
                        OperatingFrequency = c.String(),
                        MaxTurboFrequency = c.String(),
                        L3Cache = c.String(),
                        ManufacturingTech = c.String(),
                        MemoryTypes = c.String(),
                        IntergratedGraphics = c.Boolean(nullable: false),
                        IntergratedGraphicsSpec = c.String(),
                        PCIeRevision = c.String(),
                        ThermalDesignPower = c.String(),
                    })
                .PrimaryKey(t => t.CPUID);
            
            CreateTable(
                "dbo.GPU",
                c => new
                    {
                        GPUID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Brand = c.String(),
                        BrandModel = c.String(),
                        Interface = c.String(),
                        ChipsetManufacturer = c.String(),
                        GPUModel = c.String(),
                        CoreClock = c.String(),
                        BoostClock = c.String(),
                        StreamProcessors = c.String(),
                        CUDACores = c.String(),
                        EffectiveMemory = c.String(),
                        MemorySize = c.String(),
                        MemoryInterface = c.String(),
                        MemoryType = c.String(),
                        DirectX = c.String(),
                        OpenGL = c.String(),
                        DisplayPorts = c.String(),
                        FormFactor = c.String(),
                        MaxLength = c.String(),
                        SlotWidth = c.String(),
                        PowerConnector = c.String(),
                        MinimumPower = c.String(),
                        Cooler = c.String(),
                        VRReady = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.GPUID);
            
            CreateTable(
                "dbo.RAM",
                c => new
                    {
                        RAMID = c.Int(nullable: false, identity: true),
                        Brand = c.String(),
                        RAMModel = c.String(),
                        Capacity = c.String(),
                        Type = c.String(),
                        Speed = c.String(),
                        CASLatency = c.Int(nullable: false),
                        Timing = c.String(),
                        HeatSpreader = c.Boolean(nullable: false),
                        Features = c.String(),
                    })
                .PrimaryKey(t => t.RAMID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.RAM");
            DropTable("dbo.GPU");
            DropTable("dbo.CPU");
        }
    }
}
