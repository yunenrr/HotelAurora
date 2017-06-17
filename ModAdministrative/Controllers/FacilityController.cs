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
    public class FacilityController : Controller
    {
        private aurorahotelEntities db = new aurorahotelEntities();

        // GET: Facility
        public ActionResult Index()
        {
            return View(db.tbfacilities.ToList());
        }

        // GET: Facility/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbfacility tbfacility = db.tbfacilities.Find(id);
            if (tbfacility == null)
            {
                return HttpNotFound();
            }
            return View(tbfacility);
        }

        // GET: Facility/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Facility/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "idtbfacility,facility,descriptionfacility,imagefacilitypath")] tbfacility tbfacility)
        {
            if (ModelState.IsValid)
            {
                db.tbfacilities.Add(tbfacility);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tbfacility);
        }

        // GET: Facility/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbfacility tbfacility = db.tbfacilities.Find(id);
            if (tbfacility == null)
            {
                return HttpNotFound();
            }
            return View(tbfacility);
        }

        // POST: Facility/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "idtbfacility,facility,descriptionfacility,imagefacilitypath")] tbfacility tbfacility)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tbfacility).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tbfacility);
        }

        // GET: Facility/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbfacility tbfacility = db.tbfacilities.Find(id);
            if (tbfacility == null)
            {
                return HttpNotFound();
            }
            return View(tbfacility);
        }

        // POST: Facility/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            tbfacility tbfacility = db.tbfacilities.Find(id);
            db.tbfacilities.Remove(tbfacility);
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
