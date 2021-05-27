using PartPicker.Data;
using PartPicker.Data.Entities;
using PartPicker.Models.GPUModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartPicker.Services.Services
{
    public class GPUService
    {
        private readonly Guid _userId;

        public GPUService(Guid userId)
        {
            _userId = userId;
        }

        public bool CreateGPU(GPUCreate model)
        {
            var entity =
                new GPU()
                {
                    Name = model.Name,
                    Brand = model.Brand,
                    BrandModel = model.BrandModel,
                    Interface = model.Interface,
                    ChipsetManufacturer = model.ChipsetManufacturer,
                    GPUModel = model.GPUModel,
                    CoreClock = model.CoreClock,
                    BoostClock = model.BoostClock,
                    StreamProcessors = model.StreamProcessors,
                    CUDACores = model.CUDACores,
                    EffectiveMemory = model.EffectiveMemory,
                    MemorySize = model.MemorySize,
                    MemoryInterface = model.MemoryInterface,
                    MemoryType = model.MemoryType,
                    DirectX = model.DirectX,
                    OpenGL = model.OpenGL,
                    DisplayPorts = model.DisplayPorts,
                    FormFactor = model.FormFactor,
                    MaxLength = model.MaxLength,
                    SlotWidth = model.SlotWidth,
                    PowerConnector = model.PowerConnector,
                    MinimumPower = model.MinimumPower,
                    Cooler = model.Cooler,
                    VRReady = model.VRReady
                };

            using (var ctx = new ApplicationDbContext())
            {
                ctx.GPUs.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }

        public IEnumerable<GPUListItem> GetGPUs()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query =
                    ctx
                    .GPUs
                    .Select(
                        e =>
                            new GPUListItem
                            {
                                GPUID = e.GPUID,
                                Name = e.Name,
                                Brand = e.Brand,
                                ChipsetManufacturer = e.ChipsetManufacturer,
                                GPUModel = e.GPUModel,
                                CoreClock = e.CoreClock,
                            }
                    );

                return query.ToArray();
            }
        }

        public GPUDetail GetGPUById(int id)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .GPUs
                        .SingleOrDefault(e => e.GPUID == id);
                return
                    new GPUDetail
                    {
                        GPUID = entity.GPUID,
                        Name = entity.Name,
                        Brand = entity.Brand,
                        BrandModel = entity.BrandModel,
                        Interface = entity.Interface,
                        ChipsetManufacturer = entity.ChipsetManufacturer,
                        GPUModel = entity.GPUModel,
                        CoreClock = entity.CoreClock,
                        BoostClock = entity.BoostClock,
                        StreamProcessors = entity.StreamProcessors,
                        CUDACores = entity.CUDACores,
                        EffectiveMemory = entity.EffectiveMemory,
                        MemorySize = entity.MemorySize,
                        MemoryInterface = entity.MemoryInterface,
                        MemoryType = entity.MemoryType,
                        DirectX = entity.DirectX,
                        OpenGL = entity.OpenGL,
                        DisplayPorts = entity.DisplayPorts,
                        FormFactor = entity.FormFactor,
                        MaxLength = entity.MaxLength,
                        SlotWidth = entity.SlotWidth,
                        PowerConnector = entity.PowerConnector,
                        MinimumPower = entity.MinimumPower,
                        Cooler = entity.Cooler,
                        VRReady = entity.VRReady
                    };
            }
        }

        public bool UpdateGPU(GPUEdit model)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .GPUs
                        .SingleOrDefault(e => e.GPUID == model.GPUID);
                entity.GPUID = model.GPUID;
                entity.Name = model.Name;
                entity.Brand = model.Brand;
                entity.BrandModel = model.BrandModel;
                entity.Interface = model.Interface;
                entity.ChipsetManufacturer = model.ChipsetManufacturer;
                entity.GPUModel = model.GPUModel;
                entity.CoreClock = model.CoreClock;
                entity.StreamProcessors = model.StreamProcessors;
                entity.CUDACores = model.CUDACores;
                entity.EffectiveMemory = model.EffectiveMemory;
                entity.MemorySize = model.MemorySize;
                entity.MemoryInterface = model.MemoryInterface;
                entity.MemoryType = model.MemoryType;
                entity.DirectX = model.DirectX;
                entity.OpenGL = model.OpenGL;
                entity.DisplayPorts = model.DisplayPorts;
                entity.FormFactor = model.FormFactor;
                entity.MaxLength = model.MaxLength;
                entity.SlotWidth = model.SlotWidth;
                entity.PowerConnector = model.PowerConnector;
                entity.MinimumPower = model.MinimumPower;
                entity.Cooler = model.Cooler;
                entity.VRReady = model.VRReady;

                return ctx.SaveChanges() == 1;
            }
        }

        public bool DeleteGPU(int gpuID)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .GPUs
                        .SingleOrDefault(e => e.GPUID == gpuID);

                ctx.GPUs.Remove(entity);

                return ctx.SaveChanges() == 1;
            }
        }
    }
}
