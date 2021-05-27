using PartPicker.Data.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartPicker.Models.MotherboardModels
{
    public class MotherboardCreate
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Brand { get; set; }
        [Required]
        [Display(Name ="Motherbard Model")]
        public string MotherboardModel { get; set; }
        [Required]
        [Display(Name = "Motherboard Form Factor")]
        public FormFactor MotherboardFormFactor { get; set; }
        [Required]
        public string Socket { get; set; }
        [Required]
        public string Chipset { get; set; }
        [Required]
        [Display(Name = "USB Ports")]
        public string USBPorts { get; set; }
        [Required]
        [Display(Name = "RAM Slots")]
        public int RAMSlots { get; set; }
        [Required]
        [Display(Name = "RAM Type")]
        public RamType RAMType { get; set; }
        [Required]
        [Display(Name = "Max Memory Speed")]
        public string MaxMemorySpeed { get; set; }
        [Required]
        [Display(Name = "Max Memory Size")]
        public string MaxMemorySize { get; set; }
        [Required]
        [Display(Name = "Video Connectors")]
        public string VideoConnectors { get; set; }
        [Required]
        [Display(Name = "PCIe Slots")]
        public string PCIeSlots { get; set; }
        [Required]
        [Display(Name = "SATA Ports")]
        public string SataPorts { get; set; }
        [Required]
        [Display(Name = "M.2 NVMe Support")]
        public bool M2NVMeSupport { get; set; }
        [Display(Name = "M.2 NVMe Specs")]
        public string M2NVMeSpecs { get; set; }
        [Required]
        [Display(Name = "Inbuilt WiFi")]
        public bool InbuiltWifi { get; set; }
        [Required]
        [Display(Name = "RGB Header")]
        public bool RGBHeader { get; set; }
        [Display(Name = "Other Features")]
        public string OtherFeatures { get; set; }
    }
}
