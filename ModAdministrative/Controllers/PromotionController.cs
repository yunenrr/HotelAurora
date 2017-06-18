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
    public class PromotionController : Controller
    {
        private aurorahotelEntities db = new aurorahotelEntities();

        // GET: Promotion
        public ActionResult Index()
        {
            return View(db.tbpromotions.ToList());
        }

        // GET: Promotion/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbpromotion tbpromotion = db.tbpromotions.Find(id);
            if (tbpromotion == null)
            {
                return HttpNotFound();
            }
            return View(tbpromotion);
        }

        // GET: Promotion/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Promotion/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "idtbpromotion,promotion,descriptionpromotion,imagepromotion")] tbpromotion tbpromotion)
        {
            if (ModelState.IsValid)
            {
                db.tbpromotions.Add(tbpromotion);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tbpromotion);
        }

        // GET: Promotion/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbpromotion tbpromotion = db.tbpromotions.Find(id);
            if (tbpromotion == null)
            {
                return HttpNotFound();
            }
            return View(tbpromotion);
        }

        // POST: Promotion/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "idtbpromotion,promotion,descriptionpromotion,imagepromotion")] tbpromotion tbpromotion)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tbpromotion).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tbpromotion);
        }

        // GET: Promotion/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbpromotion tbpromotion = db.tbpromotions.Find(id);
            if (tbpromotion == null)
            {
                return HttpNotFound();
            }
            return View(tbpromotion);
        }

        // POST: Promotion/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            tbpromotion tbpromotion = db.tbpromotions.Find(id);
            db.tbpromotions.Remove(tbpromotion);
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
