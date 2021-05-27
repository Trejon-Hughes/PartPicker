using PartPicker.Data;
using PartPicker.Data.Entities;
using PartPicker.Models.UserBuildModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartPicker.Services.Services
{
    public class UserBuildService
    {
        private readonly Guid _userId;

        public UserBuildService(Guid userId)
        {
            _userId = userId;
        }

        public bool CreateUserBuild()
        {
            using (var ctx = new ApplicationDbContext())
            {
                if (ctx.UserBuilds.SingleOrDefault(e => e.BuildCreator == _userId) == null)
                {
                    var entity =
                        new UserBuild()
                        {
                            BuildCreator = _userId,
                            MotherboardID = 5,
                            CPUID = 3,
                            GPUID = 2,
                            RAMID = 2
                        };
                    ctx.UserBuilds.Add(entity);
                    return ctx.SaveChanges() == 1;
                }
                return true;
            }
        }

        public UserBuildDetail GetUserBuild()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .UserBuilds
                        .SingleOrDefault(e => e.BuildCreator == _userId);
                return
                    new UserBuildDetail
                    {
                        BuildID = entity.BuildID,
                        MotherboardID = entity.MotherboardID,
                        Motherboard = entity.Motherboard,
                        CPUID = entity.CPUID,
                        CPU = entity.CPU,
                        GPUID = entity.GPUID,
                        GPU = entity.GPU,
                        RAMID = entity.RAMID,
                        RAM = entity.RAM
                    };
            }
        }

        public bool UpdateUserBuild(UserBuildEdit model)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .UserBuilds
                        .SingleOrDefault(e => e.BuildCreator == _userId);

                entity.MotherboardID = model.MotherboardID;
                entity.CPUID = model.CPUID;
                entity.GPUID = model.GPUID;
                entity.RAMID = model.RAMID;
                ctx.SaveChanges();
                return true;
            }
        }
    }
}
