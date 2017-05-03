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
        //    [TestMethod]
        //    public void TestMethod1()
        //    {

        //        ReservationData rd = new ReservationData("Data Source=jocoma.database.windows.net;Initial Catalog=aurorahotel;Persist Security Info=True;User ID=jocoma;Password=jcm_12345");

        //        List<int> availables = rd.verifyReservation(1, "05/02/2017", "05/03/2017");

        //        foreach (int i in availables)
        //        {
        //            Console.WriteLine(i + " \n ");
        //        }

        //    }


        //[TestMethod]
        //public void TestMethod2()
        //{
        //    ReservationData rs = new ReservationData("Data Source = jocoma.database.windows.net; Initial Catalog = aurorahotel; Persist Security Info = True; User ID = jocoma; Password = jcm_12345");

        //    string reservationNumber = "1a2c3d";
        //    int client = 132;
        //    int creditCard = 123456;
        //    int room = 88;
        //    string inDate = "21/04/2017";
        //    string outDate = "25/04/2017";


        //    int result = rs.insertReservation(reservationNumber, client, creditCard, room, inDate, outDate);

        //    Console.WriteLine("La reservacion fue: " + result);


        //}


        //[TestMethod]
        //public void TestMethod3()
        //{
        //    ReservationData rs = new ReservationData("Data Source = jocoma.database.windows.net; Initial Catalog = aurorahotel; Persist Security Info = True; User ID = jocoma; Password = jcm_12345");


        //    int typeroom = 1;
        //    string inDate = "21/04/2017";
        //    string outDate = "25/04/2017";


        //    List<int> result = rs.verifyReservation(typeroom, inDate, outDate);

        //    Console.WriteLine("La reservacion fue: ");



        //}
        ////test insertar clientes
        //[TestMethod]
        //public void TestMethod4()
        //{
        //    ClientData rs = new ClientData("Data Source = jocoma.database.windows.net; Initial Catalog = aurorahotel; Persist Security Info = True; User ID = jocoma; Password = jcm_12345");


        //   // int idtbclient = 1;
        //    string dni = "3-356-523";
        //    string name = "Sacarias";
        //    string surnames = "Jiménez Obregón";
        //    string email = "saca24@gmail.com";
        //    string phone = "8888-8888";


        //    int result = rs.insertClient(dni, name, surnames, email, phone);

        //    Console.WriteLine("El cliente fue: "+result);



        //}

        [TestMethod]
        public void TestMethod5()
        {

            RoomData rd = new RoomData("Data Source = jocoma.database.windows.net; Initial Catalog = aurorahotel; Persist Security Info = True; User ID = jocoma; Password = jcm_12345");

            List<Room> rooms = rd.getRoomsState();

            foreach (Room i in rooms)
            {
                Console.WriteLine(i.IdRoom + " - " + i.NameRoom + " - " + i.TypeRoom + " - " + i.AvailabilityRoom + " - \n");
            }


        }

    }
}
