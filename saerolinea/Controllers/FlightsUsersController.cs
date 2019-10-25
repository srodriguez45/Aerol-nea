using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BLL.Repository;
using BLL.Model;

namespace saerolinea.Controllers
{
    public class FlightsUsersController : ApiController
    {
        protected RFlightsUsers _obj;

        public FlightsUsersController()
        {

            if (_obj == null)
            {
                _obj = new RFlightsUsers();
            }

        }

        // GET api/<controller>
        public IEnumerable<ModelFlightsUsers> Get()
        {

            var model = _obj.findAll();
            return model;

        }

        // GET api/<controller>/5
        public ModelFlightsUsers Get(int id)
        {
            return _obj.get(id);
        }

        // POST api/<controller>
        public int Post([FromBody] ModelFlightsUsers model)
        {

            return _obj.Add(model);

        }

        // PUT: api/FlightsUsers/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/FlightsUsers/5
        public void Delete(int id)
        {
        }
    }
}
