using BLL.Model;
using BLL.Repository;
using System.Collections.Generic;
using System.Web.Http;

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

            var model = _obj.FindAll();
            return model;

        }

        // GET api/<controller>/5
        public ModelUsers Get(int id)
        {
            return _obj.GetByDocument(id);
        }

        // POST api/<controller>
        public int Post([FromBody] ModelUsers model)
        {

            return _obj.Add(model);

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