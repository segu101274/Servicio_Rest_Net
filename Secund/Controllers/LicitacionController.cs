using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AttributeRouting.Web.Http;
using Newtonsoft.Json;
using Secund.BE;
using Secund.BL;

namespace Secund.Controllers
{
    public class LicitacionController : ApiController
    {
       
        // GET api/licitacion/5
        [HttpGet]
        public string obtener(int catLic)
        {
            var oBLLicitacion = new BLLicitacion();
            var oListaLicitacion = oBLLicitacion.SeleccionarTodosxFiltros(catLic);

            string sResultado = JsonConvert.SerializeObject(oListaLicitacion);
            return sResultado;
        }

        // POST api/licitacion
        public void Post([FromBody]string value)
        {
        }

        // PUT api/licitacion/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/licitacion/5
        public void Delete(int id)
        {
        }
    }
}
