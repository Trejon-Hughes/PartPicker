using Microsoft.AspNet.Identity;
using PartPicker.Models.UserBuildModels;
using PartPicker.Services.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PartPicker.WebMVC.Controllers
{
    public class UserBuildController : Controller
    {
        // GET: UserBuild
        public ActionResult Index()
        {
            var svc = CreateUserBuildService();
            svc.CreateUserBuild();
            var model = svc.GetUserBuild();
            return View(model);
        }

        [Authorize]
        public ActionResult Motherboards(int? id)
        {
            if (id.HasValue)
            {
                var svc = CreateUserBuildService();
                var detail = svc.GetUserBuild();
                var model =
                    new UserBuildEdit
                    {
                        MotherboardID = id.Value,
                        CPUID = detail.CPUID,
                        GPUID = detail.GPUID,
                        RAMID = detail.RAMID
                    };

                if (!ModelState.IsValid)
                {
                    return View(model);
                }

                if (svc.UpdateUserBuild(model))
                {
                    TempData["SaveResult"] = "Part Selected.";
                    return RedirectToAction("Index");
                }
                ModelState.AddModelError("", "Part could not be selected");
                return View(model);
            }
            else
            {
                var userId = Guid.Parse(User.Identity.GetUserId());
                var service = new MotherboardService(userId);
                var model = service.GetMotherboards();

                return View(model);
            }
        }

        [Authorize]
        public ActionResult CPUs(int? id)
        {
            if (id.HasValue)
            {
                var svc = CreateUserBuildService();
                var detail = svc.GetUserBuild();
                var model =
                    new UserBuildEdit
                    {
                        MotherboardID = detail.MotherboardID,
                        CPUID = id.Value,
                        GPUID = detail.GPUID,
                        RAMID = detail.RAMID
                    };

                if (!ModelState.IsValid)
                {
                    return View(model);
                }

                if (svc.UpdateUserBuild(model))
                {
                    TempData["SaveResult"] = "Part Selected.";
                    return RedirectToAction("Index");
                }
                ModelState.AddModelError("", "Part could not be selected");
                return View(model);
            }
            else
            {
                var userId = Guid.Parse(User.Identity.GetUserId());
                var service = new CPUService(userId);
                var model = service.GetCPUs();

                return View(model);
            }
        }

        [Authorize]
        public ActionResult GPUs(int? id)
        {
            if (id.HasValue)
            {
                var svc = CreateUserBuildService();
                var detail = svc.GetUserBuild();
                var model =
                    new UserBuildEdit
                    {
                        MotherboardID = detail.MotherboardID,
                        CPUID = detail.CPUID,
                        GPUID = id.Value,
                        RAMID = detail.RAMID
                    };

                if (!ModelState.IsValid)
                {
                    return View(model);
                }

                if (svc.UpdateUserBuild(model))
                {
                    TempData["SaveResult"] = "Part Selected.";
                    return RedirectToAction("Index");
                }
                ModelState.AddModelError("", "Part could not be selected");
                return View(model);
            }
            else
            {
                var userId = Guid.Parse(User.Identity.GetUserId());
                var service = new GPUService(userId);
                var model = service.GetGPUs();

                return View(model);
            }
        }

        [Authorize]
        public ActionResult RAM(int? id)
        {
            if (id.HasValue)
            {
                var svc = CreateUserBuildService();
                var detail = svc.GetUserBuild();
                var model =
                    new UserBuildEdit
                    {
                        MotherboardID = detail.MotherboardID,
                        CPUID = detail.CPUID,
                        GPUID = detail.GPUID,
                        RAMID = id.Value
                    };

                if (!ModelState.IsValid)
                {
                    return View(model);
                }

                if (svc.UpdateUserBuild(model))
                {
                    TempData["SaveResult"] = "Part Selected.";
                    return RedirectToAction("Index");
                }
                ModelState.AddModelError("", "Part could not be selected");
                return View(model);
            }
            else
            {
                var userId = Guid.Parse(User.Identity.GetUserId());
                var service = new RAMService(userId);
                var model = service.GetRAM();

                return View(model);
            }
        }

        public ActionResult MotherboardDetails(int id)
        {
            var userId = Guid.Parse(User.Identity.GetUserId());
            var service = new MotherboardService(userId);
            var model = service.GetMotherboardById(id);

            return View(model);
        }

        public ActionResult CPUDetails(int id)
        {
            var userId = Guid.Parse(User.Identity.GetUserId());
            var service = new CPUService(userId);
            var model = service.GetCPUById(id);

            return View(model);
        }

        public ActionResult GPUDetails(int id)
        {
            var userId = Guid.Parse(User.Identity.GetUserId());
            var service = new GPUService(userId);
            var model = service.GetGPUById(id);

            return View(model);
        }

        public ActionResult RAMDetails(int id)
        {
            var userId = Guid.Parse(User.Identity.GetUserId());
            var service = new RAMService(userId);
            var model = service.GetRAMById(id);

            return View(model);
        }

        private UserBuildService CreateUserBuildService()
        {
            var userId = Guid.Parse(User.Identity.GetUserId());

            var service = new UserBuildService(userId);
            return service;
        }
    }
}