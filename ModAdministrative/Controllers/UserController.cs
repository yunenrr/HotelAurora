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
    public class UserController : Controller
    {
        private aurorahotelEntities db = new aurorahotelEntities();

        // GET: User
        public ActionResult Index()
        {
            var tbusers = db.tbusers.Include(t => t.tbrole);
            return View(tbusers.ToList());
        }

        // GET: User/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbuser tbuser = db.tbusers.Find(id);
            if (tbuser == null)
            {
                return HttpNotFound();
            }
            return View(tbuser);
        }

        // GET: User/Create
        public ActionResult Create()
        {
            ViewBag.idtbrole = new SelectList(db.tbroles, "idtbrole", "namerole");
            return View();
        }

        // POST: User/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "idtbuser,nametbuser,password,idtbrole")] tbuser tbuser)
        {
            if (ModelState.IsValid)
            {
                db.tbusers.Add(tbuser);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.idtbrole = new SelectList(db.tbroles, "idtbrole", "namerole", tbuser.idtbrole);
            return View(tbuser);
        }

        // GET: User/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbuser tbuser = db.tbusers.Find(id);
            if (tbuser == null)
            {
                return HttpNotFound();
            }
            ViewBag.idtbrole = new SelectList(db.tbroles, "idtbrole", "namerole", tbuser.idtbrole);
            return View(tbuser);
        }

        // POST: User/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "idtbuser,nametbuser,password,idtbrole")] tbuser tbuser)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tbuser).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.idtbrole = new SelectList(db.tbroles, "idtbrole", "namerole", tbuser.idtbrole);
            return View(tbuser);
        }

        // GET: User/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbuser tbuser = db.tbusers.Find(id);
            if (tbuser == null)
            {
                return HttpNotFound();
            }
            return View(tbuser);
        }

        // POST: User/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            tbuser tbuser = db.tbusers.Find(id);
            db.tbusers.Remove(tbuser);
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
