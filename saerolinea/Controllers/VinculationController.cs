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
    public class VinculationController : ApiController
    {

        protected RFlightsUsers _obj;

        public VinculationController()
        {

            if (_obj == null)
            {
                _obj = new RFlightsUsers();
            }

        }

        public List<ModelFlightsUsers> Post([FromBody] List<ModelFlightsUsers> list)
        {

            return _obj.Add(list);

        }


    }
}
