using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartPicker.Models.CPUModels
{
    public class CPUDetail
    {
        public int CPUID { get; set; }
        public string Name { get; set; }
        public string Brand { get; set; }
        [Display(Name = "Model")]
        public string CPUModel { get; set; }
        [Display(Name = "Socket")]
        public string SocketType { get; set; }
        [Display(Name = "Core Name")]
        public string CoreName { get; set; }
        [Display(Name = "# Of Cores")]
        public int NumberOfCores { get; set; }
        [Display(Name = "# Of Threads")]
        public int NumberOfThreads { get; set; }
        [Display(Name = "Operating Frequency")]
        public string OperatingFrequency { get; set; }
        [Display(Name = "Max Turbo Frequency")]
        public string MaxTurboFrequency { get; set; }
        [Display(Name = "L3 Cache")]
        public string L3Cache { get; set; }
        [Display(Name = "Manufacturing Tech")]
        public string ManufacturingTech { get; set; }
        [Display(Name = "Memory Types")]
        public string MemoryTypes { get; set; }
        [Display(Name = "Intergrated Graphics")]
        public bool IntergratedGraphics { get; set; }
        [Display(Name = "Intergrated Graphics Specs")]
        public string IntergratedGraphicsSpec { get; set; }
        [Display(Name = "PCIe Revision")]
        public string PCIeRevision { get; set; }
        [Display(Name = "Thermal Design Power")]
        public string ThermalDesignPower { get; set; }
    }
}
