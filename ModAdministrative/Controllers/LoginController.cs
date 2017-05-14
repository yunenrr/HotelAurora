using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using ModAdministrative.Models;

namespace ModAdministrative.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Login()
        {
            return View();
        }

        //Iniciando login con session
        [HttpPost]
        public ActionResult Login(tbuser userModel)
        {
            if (ModelState.IsValid)
            {
                using (aurorahotelEntities db = new aurorahotelEntities())
                {
                    var obj = db.tbusers.Where(a => a.nametbuser == userModel.nametbuser &&
                                                    a.password == userModel.password).FirstOrDefault();

                    if (obj != null)
                    {
                        Session["nametbuser"] = obj.nametbuser.ToString();
                        Session["password"] = obj.password.ToString();

                        return RedirectToAction("Index", "Home");
                    }
                    else
                    {
                        userModel.loginErrorMessage = "El usuario no existe,los datos son incorrectos";
                        return RedirectToAction("Login", "Login");
                    }
                }
            }
            return View(userModel);
        }

        //Cerrar login con session
        public ActionResult LogOut()
        {
            string admId = (string)Session["nametbuser"];
            Session.Abandon();
            return RedirectToAction("Login", "Login");
        }


        //// GET: Login/Details/5
        //public ActionResult Details(int id)
        //{
        //    return View();
        //}

        //// GET: Login/Create
        //public ActionResult Create()
        //{
        //    return View();
        //}

        //// POST: Login/Create
        //[HttpPost]
        //public ActionResult Create(FormCollection collection)
        //{
        //    try
        //    {
        //        // TODO: Add insert logic here

        //        return RedirectToAction("Index");
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        //// GET: Login/Edit/5
        //public ActionResult Edit(int id)
        //{
        //    return View();
        //}

        //// POST: Login/Edit/5
        //[HttpPost]
        //public ActionResult Edit(int id, FormCollection collection)
        //{
        //    try
        //    {
        //        // TODO: Add update logic here

        //        return RedirectToAction("Index");
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        //// GET: Login/Delete/5
        //public ActionResult Delete(int id)
        //{
        //    return View();
        //}

        //// POST: Login/Delete/5
        //[HttpPost]
        //public ActionResult Delete(int id, FormCollection collection)
        //{
        //    try
        //    {
        //        // TODO: Add delete logic here

        //        return RedirectToAction("Index");
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}
    }
}
