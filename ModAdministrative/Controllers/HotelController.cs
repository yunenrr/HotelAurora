using ModAdministrative.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;

namespace ModAdministrative.Controllers
{
    public class HotelController : Controller
    {

        private aurorahotelEntities db = new aurorahotelEntities();

        // GET: Hotel
        public ActionResult Index()
        {
            return View("getInformation");
        }


        public ActionResult getInformation() {
            return View(db.tbhotels.Find(4));
        }

        public ActionResult setInformation()
        {

            Hotel hotel = new Hotel();
            string mision = Request.Form["mision"].ToString();
            string vision = Request.Form["vision"].ToString();
            string historia = Request.Form["historia"].ToString();
            string information = Request.Form["information"].ToString();

            Debug.WriteLine(mision + "asd");
            Debug.WriteLine(vision + "asd8");
            Debug.WriteLine(historia + "asd");
            Debug.WriteLine(information + "asd");

            var a = db.tbhotels.Find(4);
            hotel.IdHotel= 4;
            hotel.NameHotel = a.namehotel;
            hotel.BasicInformation = a.basicinformation;
            hotel.History = historia;
            hotel.Mission = mision;
            hotel.Vission = vision;
            hotel.BasicInformation = information;


            /*db.Entry(a).State = System.Data.Entity.EntityState.Modified;
            db.Entry(a).CurrentValues.SetValues(hotel);
            db.SaveChanges();*/
            var result = db.tbhotels.SingleOrDefault(b => b.idtbhotel == 4);
            if (result != null)
            {
                result.vission = vision.TrimEnd(' '); ;
                result.mission = mision.TrimEnd(' '); ;
                result.history = historia.TrimEnd(' '); ;
                result.basicinformation = information.TrimEnd(' ');
                db.SaveChanges();
            }

            return View("getInformation",db.tbhotels.Find(4));
        }


    }
}