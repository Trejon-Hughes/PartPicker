using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartPicker.Models.CPUModels
{
    public class CPUListItem
    {
        public int CPUID { get; set; }
        public string Name { get; set; }
        public string Brand { get; set; }
        [Display(Name="Socket Type")]
        public string SocketType { get; set; }
        [Display(Name = "Operating Frequency")]
        public string OperatingFrequency { get; set; }
    }
}
