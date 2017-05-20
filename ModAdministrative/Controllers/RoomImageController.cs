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
    public class RoomImageController : Controller
    {
        private aurorahotelEntities db = new aurorahotelEntities();

        // GET: RoomImage
        public ActionResult Index()
        {
            var tbimagerooms = db.tbimagerooms.Include(t => t.tbroom);
            return View(tbimagerooms.ToList());
        }

        // GET: RoomImage/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbimageroom tbimageroom = db.tbimagerooms.Find(id);
            if (tbimageroom == null)
            {
                return HttpNotFound();
            }
            return View(tbimageroom);
        }

        // GET: RoomImage/Create
        public ActionResult Create()
        {
            ViewBag.room = new SelectList(db.tbrooms, "idtbroom", "nameroom");
            return View();
        }

        // POST: RoomImage/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "idtbimageroom,imageroompath,room")] tbimageroom tbimageroom)
        {
            if (ModelState.IsValid)
            {
                db.tbimagerooms.Add(tbimageroom);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.room = new SelectList(db.tbrooms, "idtbroom", "nameroom", tbimageroom.room);
            return View(tbimageroom);
        }

        // GET: RoomImage/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbimageroom tbimageroom = db.tbimagerooms.Find(id);
            if (tbimageroom == null)
            {
                return HttpNotFound();
            }
            ViewBag.room = new SelectList(db.tbrooms, "idtbroom", "nameroom", tbimageroom.room);
            return View(tbimageroom);
        }

        // POST: RoomImage/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "idtbimageroom,imageroompath,room")] tbimageroom tbimageroom)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tbimageroom).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.room = new SelectList(db.tbrooms, "idtbroom", "nameroom", tbimageroom.room);
            return View(tbimageroom);
        }

        // GET: RoomImage/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbimageroom tbimageroom = db.tbimagerooms.Find(id);
            if (tbimageroom == null)
            {
                return HttpNotFound();
            }
            return View(tbimageroom);
        }

        // POST: RoomImage/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            tbimageroom tbimageroom = db.tbimagerooms.Find(id);
            db.tbimagerooms.Remove(tbimageroom);
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
