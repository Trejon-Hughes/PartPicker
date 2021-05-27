using PartPicker.Data;
using PartPicker.Data.Entities;
using PartPicker.Models.CPUModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartPicker.Services.Services
{
    public class CPUService
    {
        private readonly Guid _userId;

        public CPUService(Guid userId)
        {
            _userId = userId;
        }

        public bool CreateCPU(CPUCreate model)
        {
            var entity =
                new CPU()
                {
                    Name = model.Name,
                    Brand = model.Brand,
                    CPUModel = model.CPUModel,
                    SocketType = model.SocketType,
                    CoreName = model.CoreName,
                    NumberOfCores = model.NumberOfCores,
                    NumberOfThreads = model.NumberOfThreads,
                    OperatingFrequency = model.OperatingFrequency,
                    MaxTurboFrequency = model.MaxTurboFrequency,
                    L3Cache = model.L3Cache,
                    ManufacturingTech = model.ManufacturingTech,
                    MemoryTypes = model.MemoryTypes,
                    IntergratedGraphics = model.IntergratedGraphics,
                    IntergratedGraphicsSpec = model.IntergratedGraphicsSpec,
                    PCIeRevision = model.PCIeRevision,
                    ThermalDesignPower = model.ThermalDesignPower
                };

            using (var ctx = new ApplicationDbContext())
            {
                ctx.CPUs.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }

        public IEnumerable<CPUListItem> GetCPUs()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query =
                    ctx
                    .CPUs
                    .Select(
                        e =>
                            new CPUListItem
                            {
                                CPUID = e.CPUID,
                                Name = e.Name,
                                Brand = e.Brand,
                                SocketType = e.SocketType,
                                OperatingFrequency = e.OperatingFrequency
                            }
                    );

                return query.ToArray();
            }
        }

        public CPUDetail GetCPUById(int id)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .CPUs
                        .SingleOrDefault(e => e.CPUID == id);
                return
                    new CPUDetail
                    {
                        CPUID = entity.CPUID,
                        Name = entity.Name,
                        Brand = entity.Brand,
                        CPUModel = entity.CPUModel,
                        SocketType = entity.SocketType,
                        CoreName = entity.CoreName,
                        NumberOfCores = entity.NumberOfCores,
                        NumberOfThreads = entity.NumberOfThreads,
                        OperatingFrequency = entity.OperatingFrequency,
                        MaxTurboFrequency = entity.MaxTurboFrequency,
                        L3Cache = entity.L3Cache,
                        ManufacturingTech = entity.ManufacturingTech,
                        MemoryTypes = entity.MemoryTypes,
                        IntergratedGraphics = entity.IntergratedGraphics,
                        IntergratedGraphicsSpec = entity.IntergratedGraphicsSpec,
                        PCIeRevision = entity.PCIeRevision,
                        ThermalDesignPower = entity.ThermalDesignPower
                    };
            }
        }

        public bool UpdateCPU(CPUEdit model)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .CPUs
                        .SingleOrDefault(e => e.CPUID == model.CPUID);

                entity.CPUID = model.CPUID;
                entity.Name = model.Name;
                entity.Brand = model.Brand;
                entity.CPUModel = model.CPUModel;
                entity.SocketType = model.SocketType;
                entity.CoreName = model.CoreName;
                entity.NumberOfCores = model.NumberOfCores;
                entity.NumberOfThreads = model.NumberOfThreads;
                entity.OperatingFrequency = model.OperatingFrequency;
                entity.MaxTurboFrequency = model.MaxTurboFrequency;
                entity.L3Cache = model.L3Cache;
                entity.ManufacturingTech = model.L3Cache;
                entity.MemoryTypes = model.MemoryTypes;
                entity.IntergratedGraphics = model.IntergratedGraphics;
                entity.IntergratedGraphicsSpec = model.IntergratedGraphicsSpec;
                entity.PCIeRevision = model.PCIeRevision;
                entity.ThermalDesignPower = model.ThermalDesignPower;

                return ctx.SaveChanges() == 1;
            }
        }

        public bool DeleteCPU(int CPUID)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .CPUs
                        .SingleOrDefault(e => e.CPUID == CPUID);

                ctx.CPUs.Remove(entity);

                return ctx.SaveChanges() == 1;
            }
        }
    }
}
