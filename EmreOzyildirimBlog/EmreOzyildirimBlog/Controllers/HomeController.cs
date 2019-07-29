using EmreOzyildirimBlog.Models.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EmreOzyildirimBlog.Controllers
{

    public class HomeController : Controller
    {

        private DataContext db = new DataContext();

        public ActionResult Index()
        {

            return View();
        }

        public ActionResult Tecrubelerim()
        {
            return View();
        }

        public ActionResult Hakkimda()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Iletisim()
        {
            ViewBag.Message = "Your contact page.";
            var iletisimFormu = db.Iletisims.ToList();

            return View(iletisimFormu);
        }


    }
}