using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartPicker.Data.Entities
{
    public class UserBuild
    {
        [Key]
        public int BuildID { get; set; }
        public Guid BuildCreator { get; set; }
        [ForeignKey(nameof(Motherboard))]
        public int MotherboardID { get; set; }
        public virtual Motherboard Motherboard { get; set; }
        [ForeignKey(nameof(CPU))]
        public int CPUID { get; set; }
        public virtual CPU CPU { get; set; }
        [ForeignKey(nameof(GPU))]
        public int GPUID { get; set; }
        public virtual GPU GPU { get; set; }
        [ForeignKey(nameof(RAM))]
        public int RAMID { get; set; }
        public virtual RAM RAM { get; set; }
    }
}
