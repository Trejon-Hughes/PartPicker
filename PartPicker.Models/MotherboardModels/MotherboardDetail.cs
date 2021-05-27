using PartPicker.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartPicker.Models.MotherboardModels
{
    public class MotherboardDetail
    {
        public int MotherboardID { get; set; }
        public string Name { get; set; }
        public string Brand { get; set; }
        [Display(Name = "Motherboard Model")]
        public string MotherboardModel { get; set; }
        [Display(Name = "Motherboard Form Factor")]
        public FormFactor MotherboardFormFactor { get; set; }
        public string Socket { get; set; }
        public string Chipset { get; set; }
        [Display(Name = "USB Ports")]
        public string USBPorts { get; set; }
        [Display(Name = "RAM Slots")]
        public int RAMSlots { get; set; }
        [Display(Name = "RAM Type")]
        public RamType RAMType { get; set; }
        [Display(Name = "Max Memory Speed")]
        public string MaxMemorySpeed { get; set; }
        [Display(Name = "Max Memory Size")]
        public string MaxMemorySize { get; set; }
        [Display(Name = "Video Connectors")]
        public string VideoConnectors { get; set; }
        [Display(Name = "PCIe Slots")]
        public string PCIeSlots { get; set; }
        [Display(Name = "SATA Ports")]
        public string SataPorts { get; set; }
        [Display(Name = "M.2 NVMe Support")]
        public bool M2NVMeSupport { get; set; }
        [Display(Name = "M.2 NVMe Specs")]
        public string M2NVMeSpecs { get; set; }
        [Display(Name = "Inbuilt WiFi")]
        public bool InbuiltWifi { get; set; }
        [Display(Name = "RGB Header")]
        public bool RGBHeader { get; set; }
        [Display(Name = "Other Features")]
        public string OtherFeatures { get; set; }
    }
}
