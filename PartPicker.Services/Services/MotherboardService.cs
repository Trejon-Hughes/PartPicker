using PartPicker.Data;
using PartPicker.Data.Entities;
using PartPicker.Models.MotherboardModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartPicker.Services.Services
{
    public class MotherboardService
    {
        private readonly Guid _userId;

        public MotherboardService(Guid userId)
        {
            _userId = userId;
        }

        public bool CreateMotherboard(MotherboardCreate model)
        {
            var entity =
                new Motherboard()
                {
                    Name = model.Name,
                    Brand = model.Brand,
                    MotherboardModel = model.MotherboardModel,
                    MotherboardFormFactor = model.MotherboardFormFactor,
                    Socket = model.Socket,
                    Chipset = model.Chipset,
                    USBPorts = model.USBPorts,
                    RAMSlots = model.RAMSlots,
                    RAMType = model.RAMType,
                    MaxMemorySize = model.MaxMemorySize,
                    MaxMemorySpeed = model.MaxMemorySpeed,
                    VideoConnectors = model.VideoConnectors,
                    PCIeSlots = model.PCIeSlots,
                    SataPorts = model.SataPorts,
                    M2NVMeSupport = model.M2NVMeSupport,
                    M2NVMeSpecs = model.M2NVMeSpecs,
                    InbuiltWifi = model.InbuiltWifi,
                    RGBHeader = model.RGBHeader,
                    OtherFeatures = model.OtherFeatures
                };

            using (var ctx = new ApplicationDbContext())
            {
                ctx.Motherboards.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }

        public IEnumerable<MotherboardListItem> GetMotherboards()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query =
                    ctx
                    .Motherboards
                    .Select(
                        e =>
                            new MotherboardListItem
                            {
                                MotherboardID = e.MotherboardID,
                                Name = e.Name,
                                MotherboardFormFactor = e.MotherboardFormFactor.ToString(),
                                Socket = e.Socket,
                                RAMType = e.RAMType.ToString()
                            }
                    );

                return query.ToArray();
            }
        }

        public MotherboardDetail GetMotherboardById(int id)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .Motherboards
                        .SingleOrDefault(e => e.MotherboardID == id);
                return
                    new MotherboardDetail
                    {
                        MotherboardID = entity.MotherboardID,
                        Name = entity.Name,
                        Brand = entity.Brand,
                        MotherboardModel = entity.MotherboardModel,
                        MotherboardFormFactor = entity.MotherboardFormFactor,
                        Socket = entity.Socket,
                        Chipset = entity.Chipset,
                        USBPorts = entity.USBPorts,
                        RAMSlots = entity.RAMSlots,
                        RAMType = entity.RAMType,
                        MaxMemorySize = entity.MaxMemorySize,
                        MaxMemorySpeed = entity.MaxMemorySpeed,
                        VideoConnectors = entity.VideoConnectors,
                        PCIeSlots = entity.PCIeSlots,
                        SataPorts = entity.SataPorts,
                        M2NVMeSupport = entity.M2NVMeSupport,
                        M2NVMeSpecs = entity.M2NVMeSpecs,
                        InbuiltWifi = entity.InbuiltWifi,
                        RGBHeader = entity.RGBHeader,
                        OtherFeatures = entity.OtherFeatures
                    };
            }
        }

        public bool UpdateMotherboard(MotherboardEdit model)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .Motherboards
                        .SingleOrDefault(e => e.MotherboardID == model.MotherboardID);

                entity.MotherboardID = model.MotherboardID;
                entity.Name = model.Name;
                entity.Brand = model.Brand;
                entity.MotherboardModel = model.MotherboardModel;
                entity.MotherboardFormFactor = model.MotherboardFormFactor;
                entity.Socket = model.Socket;
                entity.Chipset = model.Chipset;
                entity.USBPorts = model.USBPorts;
                entity.RAMSlots = model.RAMSlots;
                entity.RAMType = model.RAMType;
                entity.MaxMemorySize = model.MaxMemorySize;
                entity.MaxMemorySpeed = model.MaxMemorySpeed;
                entity.VideoConnectors = model.VideoConnectors;
                entity.PCIeSlots = model.PCIeSlots;
                entity.SataPorts = model.SataPorts;
                entity.M2NVMeSupport = model.M2NVMeSupport;
                entity.M2NVMeSpecs = model.M2NVMeSpecs;
                entity.InbuiltWifi = model.InbuiltWifi;
                entity.RGBHeader = model.RGBHeader;
                entity.OtherFeatures = model.OtherFeatures;

                return ctx.SaveChanges() == 1;
            }
        }

        public bool DeleteMotherboard(int motherboardID)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .Motherboards
                        .SingleOrDefault(e => e.MotherboardID == motherboardID);

                ctx.Motherboards.Remove(entity);

                return ctx.SaveChanges() == 1;
            }
        }
    }
}
