using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ModAdministrative.Models;
using WebApplication2.Business;
using System.Web.Configuration;

namespace ModAdministrative.Controllers
{
    public class RoomController : Controller
    {
        private aurorahotelEntities db = new aurorahotelEntities();

        // GET: Room
        public ActionResult Index()
        {
            var tbrooms = db.tbrooms.Include(t => t.tbroomtype);
            return View(tbrooms.ToList());
        }

        // GET: Room/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbroom tbroom = db.tbrooms.Find(id);
            if (tbroom == null)
            {
                return HttpNotFound();
            }
            return View(tbroom);
        }

        // GET: Room/Create
        public ActionResult Create()
        {
            ViewBag.typeroom = new SelectList(db.tbroomtypes, "idtbroomtype", "roomtype");
            return View();
        }

        // POST: Room/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "idtbroom,nameroom,characteristics,availability,typeroom")] tbroom tbroom)
        {
            if (ModelState.IsValid)
            {
                db.tbrooms.Add(tbroom);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.typeroom = new SelectList(db.tbroomtypes, "idtbroomtype", "roomtype", tbroom.typeroom);
            return View(tbroom);
        }

        // GET: Room/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbroom tbroom = db.tbrooms.Find(id);
            if (tbroom == null)
            {
                return HttpNotFound();
            }
            ViewBag.typeroom = new SelectList(db.tbroomtypes, "idtbroomtype", "roomtype", tbroom.typeroom);
            return View(tbroom);
        }

        // POST: Room/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "idtbroom,nameroom,characteristics,availability,typeroom")] tbroom tbroom)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tbroom).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.typeroom = new SelectList(db.tbroomtypes, "idtbroomtype", "roomtype", tbroom.typeroom);
            return View(tbroom);
        }

        // GET: Room/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbroom tbroom = db.tbrooms.Find(id);
            if (tbroom == null)
            {
                return HttpNotFound();
            }
            return View(tbroom);
        }

        // POST: Room/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            tbroom tbroom = db.tbrooms.Find(id);
            db.tbrooms.Remove(tbroom);
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

        // GET: Room
        public ActionResult AvailablesRoom()
        {
            RoomBusiness rb = new RoomBusiness(WebConfigurationManager.ConnectionStrings["AzureConnString"].ToString());
            return View(rb.getRoomsState().ToList());
        }
    }//Fin de la clase
}
