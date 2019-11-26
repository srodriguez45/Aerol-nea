using System;
using BLL.Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var repo = new RFlights();
            var result = repo.Get(2);

            Assert.AreEqual("Yhon Cruz", result.pilotName);
            Assert.AreEqual(2, result.idFlight);            
        }
    }
}
