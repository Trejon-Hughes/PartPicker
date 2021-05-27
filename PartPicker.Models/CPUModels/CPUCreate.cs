using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartPicker.Models.CPUModels
{
    public class CPUCreate
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Brand { get; set; }
        [Required]
        [Display(Name ="Model")]
        public string CPUModel { get; set; }
        [Required]
        [Display(Name="Socket")]
        public string SocketType { get; set; }
        [Required]
        [Display(Name = "Core Name")]
        public string CoreName { get; set; }
        [Required]
        [Display(Name = "# Of Cores")]
        public int NumberOfCores { get; set; }
        [Required]
        [Display(Name = "# Of Threads")]
        public int NumberOfThreads { get; set; }
        [Required]
        [Display(Name = "Operating Frequency")]
        public string OperatingFrequency { get; set; }
        [Display(Name = "Max Turbo Frequency")]
        public string MaxTurboFrequency { get; set; }
        [Required]
        [Display(Name = "L3 Cache")]
        public string L3Cache { get; set; }
        [Required]
        [Display(Name = "Manufacturing Tech")]
        public string ManufacturingTech { get; set; }
        [Required]
        [Display(Name = "Memory Types")]
        public string MemoryTypes { get; set; }
        [Required]
        [Display(Name = "Intergrated Graphics")]
        public bool IntergratedGraphics { get; set; }
        [Display(Name = "Intergrated Graphics Specs")]
        public string IntergratedGraphicsSpec { get; set; }
        [Required]
        [Display(Name = "PCIe Revision")]
        public string PCIeRevision { get; set; }
        [Required]
        [Display(Name = "Thermal Design Power")]
        public string ThermalDesignPower { get; set; }
    }
}
