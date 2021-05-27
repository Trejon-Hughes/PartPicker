using PartPicker.Data;
using PartPicker.Data.Entities;
using PartPicker.Models.RAMModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartPicker.Services.Services
{
    public class RAMService
    {
        private readonly Guid _userId;

        public RAMService(Guid userId)
        {
            _userId = userId;
        }

        public bool CreateRAM(RAMCreate model)
        {
            var entity =
                new RAM()
                {
                    Brand = model.Brand,
                    RAMModel = model.RAMModel,
                    Capacity = model.Capacity,
                    Type = model.Type,
                    Speed = model.Speed,
                    CASLatency = model.CASLatency,
                    Timing = model.Timing,
                    HeatSpreader = model.HeatSpreader,
                    Features = model.Features
                };

            using (var ctx = new ApplicationDbContext())
            {
                ctx.RAMs.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }

        public IEnumerable<RAMListItem> GetRAM()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query =
                    ctx
                    .RAMs
                    .Select(
                        e =>
                            new RAMListItem
                            {
                                RAMID = e.RAMID,
                                Brand = e.Brand,
                                RAMModel = e.RAMModel,
                                Capacity = e.Capacity,
                                Type = e.Type,
                                Speed = e.Speed
                            }
                    );

                return query.ToArray();
            }
        }

        public RAMDetail GetRAMById(int id)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .RAMs
                        .SingleOrDefault(e => e.RAMID == id);
                return
                    new RAMDetail
                    {
                        RAMID = entity.RAMID,
                        Brand = entity.Brand,
                        RAMModel = entity.RAMModel,
                        Capacity = entity.Capacity,
                        Type = entity.Type,
                        Speed = entity.Speed,
                        CASLatency = entity.CASLatency,
                        Timing = entity.Timing,
                        HeatSpreader = entity.HeatSpreader,
                        Features = entity.Features
                    };
            }
        }

        public bool UpdateRAM(RAMEdit model)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .RAMs
                        .SingleOrDefault(e => e.RAMID == model.RAMID);

                entity.RAMID = model.RAMID;
                entity.Brand = model.Brand;
                entity.RAMModel = model.RAMModel;
                entity.Capacity = model.Capacity;
                entity.Type = model.Type;
                entity.Speed = model.Speed;
                entity.CASLatency = model.CASLatency;
                entity.Timing = model.Timing;
                entity.HeatSpreader = model.HeatSpreader;
                entity.Features = model.Features;

                return ctx.SaveChanges() == 1;
            }
        }

        public bool DeleteRAM(int ramID)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .RAMs
                        .SingleOrDefault(e => e.RAMID == ramID);

                ctx.RAMs.Remove(entity);

                return ctx.SaveChanges() == 1;
            }
        }
    }
}
