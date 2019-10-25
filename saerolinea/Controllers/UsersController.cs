using BLL.Model;
using BLL.Repository;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Script.Serialization;

namespace saerolinea.Controllers
{
    public class UsersController : ApiController
    {

        private RUsers _obj;

        public UsersController()
        {

            if (_obj == null)
            {
                _obj = new RUsers();
            }

        }

        // GET api/<controller>
        public IEnumerable<ModelUsers> Get()
        {

            var model = _obj.findAll();
            return model;

        }

        // GET api/<controller>/5
        public ModelUsers Get(int id)
        {
            return _obj.getByDocument(id);
        }

        // POST api/<controller>
        public int Post([FromBody] ModelUsers model)
        {

            return _obj.add(model);

        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}