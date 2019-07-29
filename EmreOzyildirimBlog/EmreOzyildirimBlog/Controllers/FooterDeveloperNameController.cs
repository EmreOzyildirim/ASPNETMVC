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
    public class FooterDeveloperNameController : Controller
    {
        private DataContext db = new DataContext();

        // GET: FooterDeveloperName
        public ActionResult Index()
        {
            return View(db.FooterDeveloperName.ToList());
        }

        // GET: FooterDeveloperName/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FooterDeveloperName footerDeveloperName = db.FooterDeveloperName.Find(id);
            if (footerDeveloperName == null)
            {
                return HttpNotFound();
            }
            return View(footerDeveloperName);
        }

        // GET: FooterDeveloperName/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: FooterDeveloperName/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,DevelopedAndDesignedText,DeveloperName,DeveloperLink")] FooterDeveloperName footerDeveloperName)
        {
            if (ModelState.IsValid)
            {
                db.FooterDeveloperName.Add(footerDeveloperName);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(footerDeveloperName);
        }

        // GET: FooterDeveloperName/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FooterDeveloperName footerDeveloperName = db.FooterDeveloperName.Find(id);
            if (footerDeveloperName == null)
            {
                return HttpNotFound();
            }
            return View(footerDeveloperName);
        }

        // POST: FooterDeveloperName/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,DevelopedAndDesignedText,DeveloperName,DeveloperLink")] FooterDeveloperName footerDeveloperName)
        {
            if (ModelState.IsValid)
            {
                db.Entry(footerDeveloperName).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(footerDeveloperName);
        }

        // GET: FooterDeveloperName/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FooterDeveloperName footerDeveloperName = db.FooterDeveloperName.Find(id);
            if (footerDeveloperName == null)
            {
                return HttpNotFound();
            }
            return View(footerDeveloperName);
        }

        // POST: FooterDeveloperName/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            FooterDeveloperName footerDeveloperName = db.FooterDeveloperName.Find(id);
            db.FooterDeveloperName.Remove(footerDeveloperName);
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
