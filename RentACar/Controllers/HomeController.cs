using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RentACar.DAL;

namespace RentACar.Controllers
{

    public class HomeController : Controller
    {
        private readonly RentACarContext _db;

        public HomeController()
        {
            _db = new RentACarContext();
        }

        public ActionResult Index()
        {
            return View(_db.Cars);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}