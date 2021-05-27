using PartPicker.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartPicker.Models.UserBuildModels
{
    public class UserBuildCreate
    {
        public Motherboard Motherboard { get; set; }
        public CPU CPU { get; set; }
        public GPU GPU { get; set; }
        public RAM RAM { get; set; }
    }
}
