using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartPicker.Data.Entities
{
    public class GPU
    {
        [Key]
        public int GPUID { get; set; }
        public string Name { get; set; }
        public string Brand { get; set; }
        public string BrandModel { get; set; }
        public string Interface { get; set; }
        public string ChipsetManufacturer { get; set; }
        public string GPUModel { get; set; }
        public string CoreClock { get; set; }
        public string BoostClock { get; set; }
        public string StreamProcessors { get; set; }
        public string CUDACores { get; set; }
        public string EffectiveMemory { get; set; }
        public string MemorySize { get; set; }
        public string MemoryInterface { get; set; }
        public string MemoryType { get; set; }
        public string DirectX { get; set; }
        public string OpenGL { get; set; }
        public string DisplayPorts { get; set; }
        public string FormFactor { get; set; }
        public string MaxLength { get; set; }
        public string SlotWidth { get; set; }
        public string PowerConnector { get; set; }
        public string MinimumPower { get; set; }
        public string Cooler { get; set; }
        public bool VRReady { get; set; }
        public virtual List<UserBuild> UserBuild { get; set; } = new List<UserBuild>();
    }
}
