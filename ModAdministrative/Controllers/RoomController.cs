using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ModAdministrative.Models;

using System.Web.Configuration;
using System.Configuration;

using WebApplication2.Business;

namespace ModAdministrative.Controllers
{
    public class RoomController : Controller
    {

        private RoomBusiness rb = new RoomBusiness(WebConfigurationManager.ConnectionStrings["AzureConnString"].ToString());
        private aurorahotelEntities db = new aurorahotelEntities();

        // GET: Room
        public ActionResult Index()
        {
            return View();
        }

        // GET: Room
        public ActionResult AvailablesRoom()
        {
            return View(rb.getRoomsState().ToList());
        }

    }
}