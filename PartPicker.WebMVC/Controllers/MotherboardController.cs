using Microsoft.AspNet.Identity;
using PartPicker.Models.MotherboardModels;
using PartPicker.Services.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PartPicker.WebMVC.Controllers
{
    public class MotherboardController : Controller
    {
        // GET: Motherboard
        public ActionResult Index()
        {
            var svc = CreateMotherboardService();
            var model = svc.GetMotherboards();

            return View(model);
        }

        //GET
        [Authorize]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public ActionResult Create(MotherboardCreate model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var svc = CreateMotherboardService();

            if (svc.CreateMotherboard(model))
            {
                TempData["SaveResult"] = "Motherboard was created.";
                return RedirectToAction("Index");
            }

            ModelState.AddModelError("", "Motherboard could not be created.");

            return View(model);
        }

        public ActionResult Details(int id)
        {
            var svc = CreateMotherboardService();
            var model = svc.GetMotherboardById(id);

            return View(model);
        }

        [Authorize]
        public ActionResult Edit(int id)
        {
            var svc = CreateMotherboardService();
            var detail = svc.GetMotherboardById(id);
            var model =
                new MotherboardEdit
                {
                    MotherboardID = detail.MotherboardID,
                    Name = detail.Name,
                    Brand = detail.Brand,
                    MotherboardModel = detail.MotherboardModel,
                    MotherboardFormFactor = detail.MotherboardFormFactor,
                    Socket = detail.Socket,
                    Chipset = detail.Chipset,
                    USBPorts = detail.USBPorts,
                    RAMSlots = detail.RAMSlots,
                    RAMType = detail.RAMType,
                    MaxMemorySize = detail.MaxMemorySize,
                    MaxMemorySpeed = detail.MaxMemorySpeed,
                    VideoConnectors = detail.VideoConnectors,
                    PCIeSlots = detail.PCIeSlots,
                    SataPorts = detail.SataPorts,
                    M2NVMeSupport = detail.M2NVMeSupport,
                    M2NVMeSpecs = detail.M2NVMeSpecs,
                    InbuiltWifi = detail.InbuiltWifi,
                    RGBHeader = detail.RGBHeader,
                    OtherFeatures = detail.OtherFeatures
                };
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public ActionResult Edit(int id, MotherboardEdit model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            if(model.MotherboardID != id)
            {
                ModelState.AddModelError("", "Id Mismatch");
                return View(model);
            }

            var svc = CreateMotherboardService();

            if (svc.UpdateMotherboard(model))
            {
                TempData["SaveResult"] = "Motherboard Updated.";
                return RedirectToAction("Index");
            }
            ModelState.AddModelError("", "Motherboard could not be updated.");
            return View(model);
        }

        [ActionName("Delete")]
        [Authorize]
        public ActionResult Delete(int id)
        {
            var svc = CreateMotherboardService();
            var model = svc.GetMotherboardById(id);

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]
        [Authorize]
        public ActionResult DeleteMB(int id)
        {
            var svc = CreateMotherboardService();

            svc.DeleteMotherboard(id);

            TempData["SaveResult"] = "Motherboard deleted.";

            return RedirectToAction("Index");
        }

        private MotherboardService CreateMotherboardService()
        {
            var userId = new Guid();
            if (User.Identity.GetUserId() != null)
            {
                userId = Guid.Parse(User.Identity.GetUserId());
            }

            var service = new MotherboardService(userId);
            return service;
        }
    }
}