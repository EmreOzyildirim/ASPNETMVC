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
    public class HakkimdaInfoController : Controller
    {
        private DataContext db = new DataContext();

        // GET: HakkimdaInfo
        public ActionResult Index()
        {
            return View(db.HakkimdaInfoes.ToList());
        }

        // GET: HakkimdaInfo/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HakkimdaInfo hakkimdaInfo = db.HakkimdaInfoes.Find(id);
            if (hakkimdaInfo == null)
            {
                return HttpNotFound();
            }
            return View(hakkimdaInfo);
        }

        // GET: HakkimdaInfo/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: HakkimdaInfo/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,HakkimdaBaslik,ProfilResmiAdresi,HakkimdaAciklama,IlkOkul,Lise,Universite")] HakkimdaInfo hakkimdaInfo)
        {
            if (ModelState.IsValid)
            {
                db.HakkimdaInfoes.Add(hakkimdaInfo);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(hakkimdaInfo);
        }

        // GET: HakkimdaInfo/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HakkimdaInfo hakkimdaInfo = db.HakkimdaInfoes.Find(id);
            if (hakkimdaInfo == null)
            {
                return HttpNotFound();
            }
            return View(hakkimdaInfo);
        }

        // POST: HakkimdaInfo/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,HakkimdaBaslik,ProfilResmiAdresi,HakkimdaAciklama,IlkOkul,Lise,Universite")] HakkimdaInfo hakkimdaInfo)
        {
            if (ModelState.IsValid)
            {
                db.Entry(hakkimdaInfo).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(hakkimdaInfo);
        }

        // GET: HakkimdaInfo/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HakkimdaInfo hakkimdaInfo = db.HakkimdaInfoes.Find(id);
            if (hakkimdaInfo == null)
            {
                return HttpNotFound();
            }
            return View(hakkimdaInfo);
        }

        // POST: HakkimdaInfo/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            HakkimdaInfo hakkimdaInfo = db.HakkimdaInfoes.Find(id);
            db.HakkimdaInfoes.Remove(hakkimdaInfo);
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
