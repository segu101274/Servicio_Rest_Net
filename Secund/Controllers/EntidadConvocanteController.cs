using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Secund.BE;

namespace Secund.Controllers
{
    public class EntidadConvocanteController : Controller
    {
        //
        // GET: /EntidadConvocante/

        public ActionResult Index()
        {
            var oEntidad = WebApiMethods<List<BEEntidadConvocante>>.Get("ObtenerEntidadConvocante/");

            return View(oEntidad);
        }

    }
}
