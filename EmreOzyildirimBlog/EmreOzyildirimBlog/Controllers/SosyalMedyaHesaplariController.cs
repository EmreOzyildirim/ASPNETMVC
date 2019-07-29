using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using EmreOzyildirimBlog.Models.Entities;

namespace EmreOzyildirimBlog.Controllers
{
    public class SosyalMedyaHesaplariController : Controller
    {
        private DataContext db = new DataContext();

        // GET: SosyalMedyaHesaplari
        public ActionResult Index()
        {
            return View(db.SosyalMedyaHesaplari.ToList());
        }

        // GET: SosyalMedyaHesaplari/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SosyalMedyaHesaplari sosyalMedyaHesaplari = db.SosyalMedyaHesaplari.Find(id);
            if (sosyalMedyaHesaplari == null)
            {
                return HttpNotFound();
            }
            return View(sosyalMedyaHesaplari);
        }

        // GET: SosyalMedyaHesaplari/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SosyalMedyaHesaplari/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,FacebookAktif,FacebookLink,InstagramAktif,InstagramLink,LinkedinAktif,LinkedinLink")] SosyalMedyaHesaplari sosyalMedyaHesaplari)
        {
            if (ModelState.IsValid)
            {
                db.SosyalMedyaHesaplari.Add(sosyalMedyaHesaplari);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(sosyalMedyaHesaplari);
        }

        // GET: SosyalMedyaHesaplari/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SosyalMedyaHesaplari sosyalMedyaHesaplari = db.SosyalMedyaHesaplari.Find(id);
            if (sosyalMedyaHesaplari == null)
            {
                return HttpNotFound();
            }
            return View(sosyalMedyaHesaplari);
        }

        // POST: SosyalMedyaHesaplari/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,FacebookAktif,FacebookLink,InstagramAktif,InstagramLink,LinkedinAktif,LinkedinLink")] SosyalMedyaHesaplari sosyalMedyaHesaplari)
        {
            if (ModelState.IsValid)
            {
                db.Entry(sosyalMedyaHesaplari).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(sosyalMedyaHesaplari);
        }

        // GET: SosyalMedyaHesaplari/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SosyalMedyaHesaplari sosyalMedyaHesaplari = db.SosyalMedyaHesaplari.Find(id);
            if (sosyalMedyaHesaplari == null)
            {
                return HttpNotFound();
            }
            return View(sosyalMedyaHesaplari);
        }

        // POST: SosyalMedyaHesaplari/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            SosyalMedyaHesaplari sosyalMedyaHesaplari = db.SosyalMedyaHesaplari.Find(id);
            db.SosyalMedyaHesaplari.Remove(sosyalMedyaHesaplari);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
