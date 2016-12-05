using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web;
using System.Web.Http.Routing;
using System.Web.Mvc;
using Secund.BE;

namespace Secund.Controllers
{
    public class SesionController : Controller
    {
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(string sCodigo, string sClave)
        {
            string[] oParametros = { "sCodigo=" + sCodigo, "sClave=" + sClave };
            var oEntidad = WebApiMethods<BECliente>.Post(oParametros, "Login");

            if (oEntidad == null)
            {
                ViewBag.Mensaje = "Las credenciales ingresadas no son las correctas.";
                return View();
            }

            return RedirectToAction("Index", "EntidadConvocante", null);
        }

    }
}
