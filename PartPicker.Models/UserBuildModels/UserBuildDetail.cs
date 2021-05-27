using PartPicker.Data.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartPicker.Models.UserBuildModels
{
    public class UserBuildDetail
    {
        public int  BuildID { get; set; }
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
