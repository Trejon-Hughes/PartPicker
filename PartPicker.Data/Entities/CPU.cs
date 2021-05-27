using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartPicker.Data.Entities
{
    public class CPU
    {
        [Key]
        public int CPUID { get; set; }
        public string Name { get; set; }
        public string Brand { get; set; }
        public string CPUModel { get; set; }
        public string SocketType { get; set; }
        public string CoreName { get; set; }
        public int NumberOfCores { get; set; }
        public int NumberOfThreads { get; set; }
        public string OperatingFrequency { get; set; }
        public string MaxTurboFrequency { get; set; }
        public string L3Cache { get; set; }
        public string ManufacturingTech { get; set; }
        public string MemoryTypes { get; set; }
        public bool IntergratedGraphics { get; set; }
        public string IntergratedGraphicsSpec { get; set; }
        public string PCIeRevision { get; set; }
        public string ThermalDesignPower { get; set; }
        public virtual List<UserBuild> UserBuild { get; set; } = new List<UserBuild>();
    }
}
