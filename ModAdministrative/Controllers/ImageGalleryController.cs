using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ModAdministrative.Models;

namespace ModAdministrative.Controllers
{
    public class ImageGalleryController : Controller
    {
        private aurorahotelEntities db = new aurorahotelEntities();

        // GET: ImageGallery
        public ActionResult Index()
        {
            return View(db.tbimagegalleries.ToList());
        }

        // GET: ImageGallery/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbimagegallery tbimagegallery = db.tbimagegalleries.Find(id);
            if (tbimagegallery == null)
            {
                return HttpNotFound();
            }
            return View(tbimagegallery);
        }

        // GET: ImageGallery/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ImageGallery/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "idtbimagegallery,imagegallerypath")] tbimagegallery tbimagegallery)
        {
            if (ModelState.IsValid)
            {
                db.tbimagegalleries.Add(tbimagegallery);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tbimagegallery);
        }

        // GET: ImageGallery/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbimagegallery tbimagegallery = db.tbimagegalleries.Find(id);
            if (tbimagegallery == null)
            {
                return HttpNotFound();
            }
            return View(tbimagegallery);
        }

        // POST: ImageGallery/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "idtbimagegallery,imagegallerypath")] tbimagegallery tbimagegallery)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tbimagegallery).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tbimagegallery);
        }

        // GET: ImageGallery/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbimagegallery tbimagegallery = db.tbimagegalleries.Find(id);
            if (tbimagegallery == null)
            {
                return HttpNotFound();
            }
            return View(tbimagegallery);
        }

        // POST: ImageGallery/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            tbimagegallery tbimagegallery = db.tbimagegalleries.Find(id);
            db.tbimagegalleries.Remove(tbimagegallery);
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
