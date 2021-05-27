using Microsoft.AspNet.Identity;
using PartPicker.Models.CPUModels;
using PartPicker.Services.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PartPicker.WebMVC.Controllers
{
    public class CPUController : Controller
    {
        // GET: CPU
        public ActionResult Index()
        {
            var svc = CreateCPUService();
            var model = svc.GetCPUs();
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
        public ActionResult Create(CPUCreate model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var svc = CreateCPUService();

            if (svc.CreateCPU(model))
            {
                TempData["SaveResult"] = "CPU was created.";
                return RedirectToAction("Index");
            }

            ModelState.AddModelError("", "CPU could not be created.");

            return View(model);
        }

        public ActionResult Details(int id)
        {
            var svc = CreateCPUService();
            var model = svc.GetCPUById(id);

            return View(model);
        }

        [Authorize]
        public ActionResult Edit(int id)
        {
            var svc = CreateCPUService();
            var detail = svc.GetCPUById(id);
            var model =
                new CPUEdit
                {
                    CPUID = detail.CPUID,
                    Name = detail.Name,
                    Brand = detail.Brand,
                    CPUModel = detail.CPUModel,
                    SocketType = detail.SocketType,
                    CoreName = detail.CoreName,
                    NumberOfCores = detail.NumberOfCores,
                    NumberOfThreads = detail.NumberOfThreads,
                    OperatingFrequency = detail.OperatingFrequency,
                    MaxTurboFrequency = detail.MaxTurboFrequency,
                    L3Cache = detail.L3Cache,
                    ManufacturingTech = detail.ManufacturingTech,
                    MemoryTypes = detail.MemoryTypes,
                    IntergratedGraphics = detail.IntergratedGraphics,
                    IntergratedGraphicsSpec = detail.IntergratedGraphicsSpec,
                    PCIeRevision = detail.PCIeRevision,
                    ThermalDesignPower = detail.ThermalDesignPower
                };
            return View(model);
        }

        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, CPUEdit model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            if (model.CPUID != id)
            {
                ModelState.AddModelError("", "Id Mismatch");
                return View(model);
            }

            var svc = CreateCPUService();

            if (svc.UpdateCPU(model))
            {
                TempData["SaveResult"] = "CPU Updated.";
                return RedirectToAction("Index");
            }
            ModelState.AddModelError("", "CPU could not be updated.");
            return View(model);
        }

        [ActionName("Delete")]
        [Authorize]
        public ActionResult Delete(int id)
        {
            var svc = CreateCPUService();
            var model = svc.GetCPUById(id);

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]
        [Authorize]
        public ActionResult DeleteCPU(int id)
        {
            var svc = CreateCPUService();
            svc.DeleteCPU(id);
            TempData["SaveResult"] = "CPU deleted.";

            return RedirectToAction("Index");
        }

        private CPUService CreateCPUService()
        {
            var userId = new Guid();
            if (User.Identity.GetUserId() != null)
            {
                userId = Guid.Parse(User.Identity.GetUserId());
            }

            var service = new CPUService(userId);
            return service;
        }
    }
}