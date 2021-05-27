using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartPicker.Models.RAMModels
{
    public class RAMListItem
    {
        public int RAMID { get; set; }
        public string Brand { get; set; }
        [Display(Name = "RAM Model")]
        public string RAMModel { get; set; }
        public string Capacity { get; set; }
        public string Type { get; set; }
        public string Speed { get; set; }
    }
}
