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
    public class FooterMenuAktifMiController : Controller
    {
        private DataContext db = new DataContext();

        // GET: FooterMenuAktifMi
        public ActionResult Index()
        {
            return View(db.FooterMenuAktifMi.ToList());
        }

        // GET: FooterMenuAktifMi/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FooterMenuAktifMi footerMenuAktifMi = db.FooterMenuAktifMi.Find(id);
            if (footerMenuAktifMi == null)
            {
                return HttpNotFound();
            }
            return View(footerMenuAktifMi);
        }

        // GET: FooterMenuAktifMi/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: FooterMenuAktifMi/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,footerNavMenu")] FooterMenuAktifMi footerMenuAktifMi)
        {
            if (ModelState.IsValid)
            {
                db.FooterMenuAktifMi.Add(footerMenuAktifMi);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(footerMenuAktifMi);
        }

        // GET: FooterMenuAktifMi/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FooterMenuAktifMi footerMenuAktifMi = db.FooterMenuAktifMi.Find(id);
            if (footerMenuAktifMi == null)
            {
                return HttpNotFound();
            }
            return View(footerMenuAktifMi);
        }

        // POST: FooterMenuAktifMi/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,footerNavMenu")] FooterMenuAktifMi footerMenuAktifMi)
        {
            if (ModelState.IsValid)
            {
                db.Entry(footerMenuAktifMi).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(footerMenuAktifMi);
        }

        // GET: FooterMenuAktifMi/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FooterMenuAktifMi footerMenuAktifMi = db.FooterMenuAktifMi.Find(id);
            if (footerMenuAktifMi == null)
            {
                return HttpNotFound();
            }
            return View(footerMenuAktifMi);
        }

        // POST: FooterMenuAktifMi/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            FooterMenuAktifMi footerMenuAktifMi = db.FooterMenuAktifMi.Find(id);
            db.FooterMenuAktifMi.Remove(footerMenuAktifMi);
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
