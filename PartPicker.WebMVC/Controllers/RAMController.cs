using Microsoft.AspNet.Identity;
using PartPicker.Models.RAMModels;
using PartPicker.Services.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PartPicker.WebMVC.Controllers
{
    public class RAMController : Controller
    {
        // GET: RAM
        public ActionResult Index()
        {
            var svc = CreateRAMService();
            var model = svc.GetRAM();

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
        public ActionResult Create(RAMCreate model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var svc = CreateRAMService();

            if (svc.CreateRAM(model))
            {
                TempData["SaveResult"] = "RAM was created.";
                return RedirectToAction("Index");
            }

            ModelState.AddModelError("", "RAM could not be created.");

            return View(model);
        }

        public ActionResult Details(int id)
        {
            var svc = CreateRAMService();
            var model = svc.GetRAMById(id);

            return View(model);
        }

        [Authorize]
        public ActionResult Edit(int id)
        {
            var svc = CreateRAMService();
            var detail = svc.GetRAMById(id);
            var model =
                new RAMEdit
                {
                    RAMID = detail.RAMID,
                    Brand = detail.Brand,
                    RAMModel = detail.RAMModel,
                    Capacity = detail.Capacity,
                    Type = detail.Type,
                    Speed = detail.Speed,
                    CASLatency = detail.CASLatency,
                    Timing = detail.Timing,
                    HeatSpreader = detail.HeatSpreader,
                    Features = detail.Features
                };
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public ActionResult Edit(int id, RAMEdit model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            if (model.RAMID != id)
            {
                ModelState.AddModelError("", "Id Mismatch");
                return View(model);
            }

            var svc = CreateRAMService();

            if (svc.UpdateRAM(model))
            {
                TempData["SaveResult"] = "RAM updated.";
                return RedirectToAction("Index");
            }
            ModelState.AddModelError("", "RAM could not be updated.");
            return View(model);
        }

        [ActionName("Delete")]
        [Authorize]
        public ActionResult Delete(int id)
        {
            var svc = CreateRAMService();
            var model = svc.GetRAMById(id);

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]
        [Authorize]
        public ActionResult DeleteRAM(int id)
        {
            var svc = CreateRAMService();
            svc.DeleteRAM(id);
            TempData["SaveResult"] = "RAM deleted.";

            return RedirectToAction("Index");
        }

        private RAMService CreateRAMService()
        {
            var userId = new Guid();
            if (User.Identity.GetUserId() != null)
            {
                userId = Guid.Parse(User.Identity.GetUserId());
            }

            var service = new RAMService(userId);
            return service;
        }
    }
}