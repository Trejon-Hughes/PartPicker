using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartPicker.Data.Entities
{
    public enum RamType { DDR3, DDR4, DDR5 }
    public enum FormFactor { ATX, MicroATX, MiniITX }
    public class Motherboard
    {
        [Key]
        public int MotherboardID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Brand { get; set; }
        [Required]
        public string MotherboardModel { get; set; }
        [Required]
        public FormFactor MotherboardFormFactor { get; set; }
        [Required]
        public string Socket { get; set; }
        [Required]
        public string Chipset { get; set; }
        [Required]
        public string USBPorts { get; set; }
        [Required]
        public int RAMSlots { get; set; }
        [Required]
        public RamType RAMType { get; set; }
        [Required]
        public string MaxMemorySpeed { get; set; }
        [Required]
        public string MaxMemorySize { get; set; }
        [Required]
        public string VideoConnectors { get; set; }
        [Required]
        public string PCIeSlots { get; set; }
        [Required]
        public string SataPorts { get; set; }
        [Required]
        public bool M2NVMeSupport { get; set; }
        public string M2NVMeSpecs { get; set; }
        [Required]
        public bool InbuiltWifi { get; set; }
        [Required]
        public bool RGBHeader { get; set; }
        public string OtherFeatures { get; set; }
        public virtual List<UserBuild> UserBuild { get; set; } = new List<UserBuild>();
    }
}
