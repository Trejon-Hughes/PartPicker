using Microsoft.AspNet.Identity;
using PartPicker.Models.GPUModels;
using PartPicker.Services.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PartPicker.WebMVC.Controllers
{
    public class GPUController : Controller
    {
        // GET: GPU
        public ActionResult Index()
        {
            var svc = CreateGPUService();
            var model = svc.GetGPUs();

            return View(model);
        }

        [Authorize]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public ActionResult Create(GPUCreate model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var svc = CreateGPUService();

            if (svc.CreateGPU(model))
            {
                TempData["SaveResult"] = "GPU was created.";
                return RedirectToAction("Index");
            }

            ModelState.AddModelError("", "GPU was created.");

            return View(model);
        }

        public ActionResult Details(int id)
        {
            var svc = CreateGPUService();
            var model = svc.GetGPUById(id);

            return View(model);
        }

        [Authorize]
        public ActionResult Edit(int id)
        {
            var svc = CreateGPUService();
            var detail = svc.GetGPUById(id);
            var model =
                new GPUEdit
                {
                    GPUID = detail.GPUID,
                    Name = detail.Name,
                    Brand = detail.Brand,
                    BrandModel = detail.BrandModel,
                    Interface = detail.Interface,
                    ChipsetManufacturer = detail.ChipsetManufacturer,
                    GPUModel = detail.GPUModel,
                    CoreClock = detail.CoreClock,
                    BoostClock = detail.BoostClock,
                    StreamProcessors = detail.StreamProcessors,
                    CUDACores = detail.CUDACores,
                    EffectiveMemory = detail.EffectiveMemory,
                    MemorySize = detail.MemorySize,
                    MemoryInterface = detail.MemoryInterface,
                    MemoryType = detail.MemoryType,
                    DirectX = detail.DirectX,
                    OpenGL = detail.OpenGL,
                    DisplayPorts = detail.DisplayPorts,
                    FormFactor = detail.FormFactor,
                    MaxLength = detail.MaxLength,
                    SlotWidth = detail.SlotWidth,
                    PowerConnector = detail.PowerConnector,
                    MinimumPower = detail.MinimumPower,
                    Cooler = detail.Cooler,
                    VRReady = detail.VRReady
                };
            return View(model);
        }

        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, GPUEdit model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            if (model.GPUID != id)
            {
                ModelState.AddModelError("", "Id Mismatch");
                return View(model);
            }

            var svc = CreateGPUService();

            if (svc.UpdateGPU(model))
            {
                TempData["SaveResult"] = "GPU updated.";
                return RedirectToAction("Index");
            }

            ModelState.AddModelError("", "GPU could not be updated.");
            return View(model);
        }

        [ActionName("Delete")]
        [Authorize]
        public ActionResult Delete(int id)
        {
            var svc = CreateGPUService();
            var model = svc.GetGPUById(id);

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]
        [Authorize]
        public ActionResult DeleteGPU(int id)
        {
            var svc = CreateGPUService();
            svc.DeleteGPU(id);
            TempData["SaveResult"] = "GPU deleted.";

            return RedirectToAction("Index");
        }

        private GPUService CreateGPUService()
        {
            var userId = new Guid();
            if (User.Identity.GetUserId() != null)
            {
                userId = Guid.Parse(User.Identity.GetUserId());
            }

            var service = new GPUService(userId);
            return service;
        }
    }
}