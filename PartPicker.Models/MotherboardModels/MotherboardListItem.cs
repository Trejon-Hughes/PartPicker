using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartPicker.Models.MotherboardModels
{
    public class MotherboardListItem
    {
        public int MotherboardID { get; set; }
        public string Name { get; set; }
        [Display(Name="Form Factor")]
        public string MotherboardFormFactor { get; set; }
        public string Socket { get; set; }
        [Display(Name="RAM Type")]
        public string RAMType { get; set; }
    }
}
