using System;
using System.Collections.Generic;
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
    public class UsuarioController : ApiController
    {
        // GET api/<controller>
        [HttpGet]
        public string obtener(string ruc, string claUsu)
        {
            var oBLCliente = new BLCliente();
            var oBECliente = oBLCliente.LoginSeleccionarUno(ruc, claUsu);

            string sResultado = JsonConvert.SerializeObject(oBECliente);
            return sResultado;
        }
        
        // POST api/<controller>
        [HttpPost]
        public BECliente crear()
        {
            //var oBLClientes = new BLCliente();
            //return oBLClientes.LoginSeleccionarUno(sCodigo, sClave);
            return null;
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