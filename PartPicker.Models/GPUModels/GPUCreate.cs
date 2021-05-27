using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartPicker.Models.GPUModels
{
    public class GPUCreate
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Brand { get; set; }
        [Required]
        [Display(Name ="Brand Model")]
        public string BrandModel { get; set; }
        [Required]
        public string Interface { get; set; }
        [Required]
        [Display(Name = "Chipset Manufacturer")]
        public string ChipsetManufacturer { get; set; }
        [Required]
        [Display(Name = "GPU Model")]
        public string GPUModel { get; set; }
        [Required]
        [Display(Name = "Core Clock")]
        public string CoreClock { get; set; }
        [Display(Name = "Boost Clock")]
        public string BoostClock { get; set; }
        [Display(Name = "Stream Processors")]
        public string StreamProcessors { get; set; }
        [Display(Name = "CUDA Cores")]
        public string CUDACores { get; set; }
        [Required]
        [Display(Name = "Effective Memory")]
        public string EffectiveMemory { get; set; }
        [Required]
        [Display(Name = "Memory Size")]
        public string MemorySize { get; set; }
        [Required]
        [Display(Name = "Memory Interface")]
        public string MemoryInterface { get; set; }
        [Required]
        [Display(Name = "Memory Type")]
        public string MemoryType { get; set; }
        [Required]
        public string DirectX { get; set; }
        [Required]
        public string OpenGL { get; set; }
        [Required]
        [Display(Name = "Display Ports")]
        public string DisplayPorts { get; set; }
        [Required]
        [Display(Name = "Form Factor")]
        public string FormFactor { get; set; }
        [Required]
        [Display(Name = "Max Length")]
        public string MaxLength { get; set; }
        [Required]
        [Display(Name = "Slot Width")]
        public string SlotWidth { get; set; }
        [Required]
        [Display(Name = "Power Connector")]
        public string PowerConnector { get; set; }
        [Required]
        [Display(Name = "Minimum Power")]
        public string MinimumPower { get; set; }
        [Required]
        public string Cooler { get; set; }
        [Required]
        public bool VRReady { get; set; }
    }
}
