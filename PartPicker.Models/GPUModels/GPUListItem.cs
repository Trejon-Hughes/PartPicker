using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartPicker.Models.GPUModels
{
    public class GPUListItem
    {
        public int GPUID { get; set; }
        public string Name { get; set; }
        public string Brand { get; set; }
        [Display(Name = "Chipset Manufacturer")]
        public string ChipsetManufacturer { get; set; }
        [Display(Name = "GPU Model")]
        public string GPUModel { get; set; }
        [Display(Name = "Core Clock")]
        public string CoreClock { get; set; }
    }
}
