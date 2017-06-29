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
    public class AdvertisingController : Controller
    {
        private aurorahotelEntities db = new aurorahotelEntities();

        public ActionResult Index()
        {
            //Se valida la autorización
            if (!Session["role"].ToString().Equals("1"))
            {
                return RedirectToAction("Index", "Home");
            }

            return View(db.tbadvertisings.ToList());
        }

        // GET: Facility/Details/5
        public ActionResult Details(int? id)
        {
            //Se valida la autorización
            if (!Session["role"].ToString().Equals("1"))
            {
                return RedirectToAction("Index", "Home");
            }

            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            tbadvertising tbadvertising = db.tbadvertisings.Find(id);
            if (tbadvertising == null)
            {
                return HttpNotFound();
            }
            return View(tbadvertising);
        }

        // GET: Facility/Create
        public ActionResult Create()
        {
            //Se valida la autorización
            if (!Session["role"].ToString().Equals("1"))
            {
                return RedirectToAction("Index", "Home");
            }

            return View();
        }

        // POST: Advertising/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "idtbadvertising,imageadvertisingpath,urladvertising")] tbadvertising tbadvertising)
        {
            //Se valida la autorización
            if (!Session["role"].ToString().Equals("1"))
            {
                return RedirectToAction("Index", "Home");
            }

            if (ModelState.IsValid)
            {
                db.tbadvertisings.Add(tbadvertising);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tbadvertising);
        }

        // GET: Promotion/Delete/5
        public ActionResult Delete(int? id)
        {
            //Se valida la autorización
            if (!Session["role"].ToString().Equals("1"))
            {
                return RedirectToAction("Index", "Home");
            }

            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbadvertising tbadvertising = db.tbadvertisings.Find(id);
            if (tbadvertising == null)
            {
                return HttpNotFound();
            }
            return View(tbadvertising);
        }

        // POST: Promotion/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            tbadvertising tbadvertising = db.tbadvertisings.Find(id);
            db.tbadvertisings.Remove(tbadvertising);
            db.SaveChanges();
            return RedirectToAction("Index");
        }




        // GET: Promotion/Edit/5
        public ActionResult Edit(int? id)
        {
            //Se valida la autorización
            if (!Session["role"].ToString().Equals("1"))
            {
                return RedirectToAction("Index", "Home");
            }

            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbadvertising tbadvertising = db.tbadvertisings.Find(id);
            if (tbadvertising == null)
            {
                return HttpNotFound();
            }
            return View(tbadvertising);
        }

        // POST: Promotion/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "idtbadvertising,imageadvertisingpath,urladvertising")] tbadvertising tbadvertising)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tbadvertising).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tbadvertising);
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
