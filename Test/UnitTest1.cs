using BLL.Model;
using NUnit.Framework;
using saerolinea.Controllers;

namespace Test
{
    [TestFixture]
    public class UnitTest1
    {
        FlightsController flights;

        [SetUp]
        public void Init()
        {
            flights = new FlightsController();            
        }

        [Test]
        public void GetFlights()
        {
            var result = new ModelFlights
            {
                idFlight = 2,
                pilotName = "Yhon Cruz"
            };
            //var result = flights.Get(2);

            Assert.AreEqual("Yhon Cruz", result.pilotName);
            Assert.AreEqual(2, result.idFlight);
        }
    }
}
