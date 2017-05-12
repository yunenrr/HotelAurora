﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using ModAdministrative.Models;

namespace ModAdministrative.Controllers
{
    public class AdministratorController : Controller
    {
        // GET: Administrator
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Registrar(ModAdministrative.Models.tbuseradmin userModel)
        {
            using (aurorahotelEntities db = new aurorahotelEntities())
            {
                var userDetails = db.tbuseradmins.Where(x => x.nameuseradmin == userModel.nameuseradmin &&
                                                             x.emailuseradmin == userModel.emailuseradmin &&
                                                             x.passworduseradmin == userModel.passworduseradmin).FirstOrDefault();

                if (userDetails == null)
                {
                    userModel.loginErrorMessage = "Datos invalidos, Admin no registrado";
                    return View("Index", userModel);
                }
                else {
                    Session["idtbuseradmin"] = userDetails.idtbuseradmin;
                    Session["nameuseradmin"] = userDetails.nameuseradmin;

                    return RedirectToAction("Index", "HomeAdmin");
                }
            }
                
        }

        public ActionResult LogOut()
        {
            int admId = (int)Session["idtbuseradmin"];
            Session.Abandon();
            return RedirectToAction("Index", "Administrator");
        }
     
        


    }
}