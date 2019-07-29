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
    public class BloggerAdiController : Controller
    {
        private DataContext db = new DataContext();

        // GET: BloggerAdi
        public ActionResult Index()
        {
            return View(db.BloggerAdi.ToList());
        }

        // GET: BloggerAdi/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BloggerAdi bloggerAdi = db.BloggerAdi.Find(id);
            if (bloggerAdi == null)
            {
                return HttpNotFound();
            }
            return View(bloggerAdi);
        }

        // GET: BloggerAdi/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BloggerAdi/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,BloggerIsim,Slogan")] BloggerAdi bloggerAdi)
        {
            if (ModelState.IsValid)
            {
                db.BloggerAdi.Add(bloggerAdi);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(bloggerAdi);
        }

        // GET: BloggerAdi/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BloggerAdi bloggerAdi = db.BloggerAdi.Find(id);
            if (bloggerAdi == null)
            {
                return HttpNotFound();
            }
            return View(bloggerAdi);
        }

        // POST: BloggerAdi/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,BloggerIsim,Slogan")] BloggerAdi bloggerAdi)
        {
            if (ModelState.IsValid)
            {
                db.Entry(bloggerAdi).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(bloggerAdi);
        }

        // GET: BloggerAdi/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BloggerAdi bloggerAdi = db.BloggerAdi.Find(id);
            if (bloggerAdi == null)
            {
                return HttpNotFound();
            }
            return View(bloggerAdi);
        }

        // POST: BloggerAdi/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            BloggerAdi bloggerAdi = db.BloggerAdi.Find(id);
            db.BloggerAdi.Remove(bloggerAdi);
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
