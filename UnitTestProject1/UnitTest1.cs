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
    }
}
