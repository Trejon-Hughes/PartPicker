using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartPicker.Models.GPUModels
{
    public class GPUEdit
    {
        public int GPUID { get; set; }
        public string Name { get; set; }
        public string Brand { get; set; }
        [Display(Name = "Brand Model")]
        public string BrandModel { get; set; }
        public string Interface { get; set; }
        [Display(Name = "Chipset Manufacturer")]
        public string ChipsetManufacturer { get; set; }
        [Display(Name = "GPU Model")]
        public string GPUModel { get; set; }
        [Display(Name = "Core Clock")]
        public string CoreClock { get; set; }
        [Display(Name = "Boost Clock")]
        public string BoostClock { get; set; }
        [Display(Name = "Stream Processors")]
        public string StreamProcessors { get; set; }
        [Display(Name = "CUDA Cores")]
        public string CUDACores { get; set; }
        [Display(Name = "Effective Memory")]
        public string EffectiveMemory { get; set; }
        [Display(Name = "Memory Size")]
        public string MemorySize { get; set; }
        [Display(Name = "Memory Interface")]
        public string MemoryInterface { get; set; }
        [Display(Name = "Memory Type")]
        public string MemoryType { get; set; }
        public string DirectX { get; set; }
        public string OpenGL { get; set; }
        [Display(Name = "Display Ports")]
        public string DisplayPorts { get; set; }
        [Display(Name = "Form Factor")]
        public string FormFactor { get; set; }
        [Display(Name = "Max Length")]
        public string MaxLength { get; set; }
        [Display(Name = "Lot Width")]
        public string SlotWidth { get; set; }
        [Display(Name = "Power Connector")]
        public string PowerConnector { get; set; }
        [Display(Name = "Minimum Power")]
        public string MinimumPower { get; set; }
        public string Cooler { get; set; }
        [Display(Name = "VR Ready")]
        public bool VRReady { get; set; }
    }
}
