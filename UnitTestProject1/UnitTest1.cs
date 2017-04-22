using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

using WebApplication2.Data;
using WebApplication2.Business;
using WebApplication2.Models;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {

            //ReservationData rd = new ReservationData("Data Source=jocoma.database.windows.net;Initial Catalog=aurorahotel;Persist Security Info=True;User ID=jocoma;Password=jcm_12345");
            ImageRoomBusiness irb= new ImageRoomBusiness("Data Source = jocoma.database.windows.net; Initial Catalog = aurorahotel; Persist Security Info = True; User ID = jocoma; Password = jcm_12345");
            //ImageRoomData ird = new ImageRoomData("Data Source=jocoma.database.windows.net;Initial Catalog=aurorahotel;Persist Security Info=True;User ID=jocoma;Password=jcm_12345");
            List<ImageRoom> result = irb.getImageRoomByRoom(1);

            foreach (ImageRoom i in result)
            {
                Console.WriteLine("Id: " + i.ImageRoomPath);
            }
        }


        [TestMethod]
        public void TestMethod2()
        {
            ReservationData rs = new ReservationData("Data Source = jocoma.database.windows.net; Initial Catalog = aurorahotel; Persist Security Info = True; User ID = jocoma; Password = jcm_12345");

            string reservationNumber = "1a2c3d";
            int client = 132;
            int creditCard = 123456;
            int room = 88;
            string inDate = "21/04/2017";
            string outDate = "25/04/2017";


            int result = rs.insertReservation(reservationNumber, client, creditCard, room, inDate, outDate);

            Console.WriteLine("La reservacion fue: " + result);


        }


        [TestMethod]
        public void TestMethod3()
        {
            ReservationData rs = new ReservationData("Data Source = jocoma.database.windows.net; Initial Catalog = aurorahotel; Persist Security Info = True; User ID = jocoma; Password = jcm_12345");

            
            int typeroom = 1;
            string inDate = "21/04/2017";
            string outDate = "25/04/2017";


            List<int> result = rs.verifyReservation(typeroom, inDate, outDate);

            Console.WriteLine("La reservacion fue: ");



        }
    }
}
