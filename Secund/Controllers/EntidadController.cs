using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AttributeRouting.Web.Http;
using Secund.BE;
using Secund.BL;

namespace Secund.Controllers
{
    public class EntidadController : ApiController
    {
        // GET api/<controller>
        [POST("ObtenerEntidadConvocante")]
        public List<BEEntidadConvocante> Get()
        {
            var oBLEntidadConvocante = new BLEntidadConvocante();
            return oBLEntidadConvocante.SeleccionarTodos();
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        public void Post([FromBody]string value)
        {
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