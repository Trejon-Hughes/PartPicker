using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartPicker.Data.Entities
{
    public class RAM
    {
        [Key]
        public int RAMID { get; set; }
        public string Brand { get; set; }
        public string RAMModel { get; set; }
        public string Capacity { get; set; }
        public string Type { get; set; }
        public string Speed { get; set; }
        public int CASLatency { get; set; }
        public string Timing { get; set; }
        public bool HeatSpreader { get; set; }
        public string Features { get; set; }
        public virtual List<UserBuild> UserBuild { get; set; } = new List<UserBuild>();
    }
}
