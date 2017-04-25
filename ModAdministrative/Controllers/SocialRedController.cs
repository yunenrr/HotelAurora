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
    public class SocialRedController : Controller
    {
        private aurorahotelEntities db = new aurorahotelEntities();

        // GET: SocialRed
        public ActionResult Index()
        {
            return View(db.tbsocialreds.ToList());
        }

        // GET: SocialRed/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbsocialred tbsocialred = db.tbsocialreds.Find(id);
            if (tbsocialred == null)
            {
                return HttpNotFound();
            }
            return View(tbsocialred);
        }

        // GET: SocialRed/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SocialRed/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "idtbsocialred,socialred,urlsocialred")] tbsocialred tbsocialred)
        {
            if (ModelState.IsValid)
            {
                db.tbsocialreds.Add(tbsocialred);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tbsocialred);
        }

        // GET: SocialRed/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbsocialred tbsocialred = db.tbsocialreds.Find(id);
            if (tbsocialred == null)
            {
                return HttpNotFound();
            }
            return View(tbsocialred);
        }

        // POST: SocialRed/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "idtbsocialred,socialred,urlsocialred")] tbsocialred tbsocialred)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tbsocialred).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tbsocialred);
        }

        // GET: SocialRed/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbsocialred tbsocialred = db.tbsocialreds.Find(id);
            if (tbsocialred == null)
            {
                return HttpNotFound();
            }
            return View(tbsocialred);
        }

        // POST: SocialRed/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            tbsocialred tbsocialred = db.tbsocialreds.Find(id);
            db.tbsocialreds.Remove(tbsocialred);
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
