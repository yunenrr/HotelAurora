using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

using WebApplication2.Data;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {

            ReservationData rd = new ReservationData("Data Source=jocoma.database.windows.net;Initial Catalog=aurorahotel;Persist Security Info=True;User ID=jocoma;Password=jcm_12345");
            List<int> result = rd.verifyReservation("2017/03/28", "2017/04/01");

            foreach (int i in result)
            {
                Console.WriteLine("Id: " + i);
            }
        }
    }
}
