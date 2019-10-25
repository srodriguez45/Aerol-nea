using BLL.Model;
using BLL.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace saerolinea.Controllers
{
    public class FlightsController : ApiController
    {

        private RFlights _obj;

        public FlightsController()
        {

            if (_obj == null)
            {
                _obj = new RFlights();
            }

        }

        // GET: api/Flights
        public IEnumerable<ModelFlights> Get()
        {

            var model = _obj.FindAll();
            return model;

        }

        // GET: api/Flights/5
        public ModelFlights Get(int id)
        {
            return _obj.Get(id);
        }

        // POST api/<controller>
        public int Post([FromBody] ModelFlights model)
        {

            return _obj.add(model);

        }

        // PUT: api/Flights/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Flights/5
        public void Delete(int id)
        {
        }
    }
}
