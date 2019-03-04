using RentACar.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RentACar.DAL;
using RentACar.Models;

namespace RentACar.Controllers
{
    public class CarController : Controller
    {
        private readonly RentACarContext _db;

        public CarController()
        {
            _db = new RentACarContext();
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create([Bind(Include = "Brand, Model, Year, EnginePower, HorsePower, EngineType, Mileage")]Car car)
        {
            if (!ModelState.IsValid)
            {
                return View(car);
            }

            _db.Cars.Add(car);
            _db.SaveChanges();

            return RedirectToAction("Index", "Home");
        }
    }
}