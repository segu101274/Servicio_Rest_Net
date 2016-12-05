using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Secund.BE;

namespace Secund.Controllers
{
    public class HomeController : Controller
    {

        [HttpGet]
        public ActionResult Index()
        {
            string[] oParametros = {  };
            var oEntidad = WebApiMethods<List<BECliente>>.Get("ObtenerClientes/");

            return View(oEntidad);
        }
    }
}
