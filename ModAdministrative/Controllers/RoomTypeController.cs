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
    public class RoomTypeController : Controller
    {
        private aurorahotelEntities db = new aurorahotelEntities();

        // GET: RoomType
        public ActionResult Index()
        {
            return View(db.tbroomtypes.ToList());
        }

        // GET: RoomType/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbroomtype tbroomtype = db.tbroomtypes.Find(id);
            if (tbroomtype == null)
            {
                return HttpNotFound();
            }
            return View(tbroomtype);
        }

        // GET: RoomType/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: RoomType/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "idtbroomtype,roomtype,descriptionroom,quantitypersons,price,imagepathroomtype")] tbroomtype tbroomtype)
        {
            if (ModelState.IsValid)
            {
                db.tbroomtypes.Add(tbroomtype);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tbroomtype);
        }

        // GET: RoomType/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbroomtype tbroomtype = db.tbroomtypes.Find(id);
            if (tbroomtype == null)
            {
                return HttpNotFound();
            }
            return View(tbroomtype);
        }

        // POST: RoomType/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "idtbroomtype,roomtype,descriptionroom,quantitypersons,price,imagepathroomtype")] tbroomtype tbroomtype)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tbroomtype).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tbroomtype);
        }

        // GET: RoomType/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbroomtype tbroomtype = db.tbroomtypes.Find(id);
            if (tbroomtype == null)
            {
                return HttpNotFound();
            }
            return View(tbroomtype);
        }

        // POST: RoomType/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            tbroomtype tbroomtype = db.tbroomtypes.Find(id);
            db.tbroomtypes.Remove(tbroomtype);
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
