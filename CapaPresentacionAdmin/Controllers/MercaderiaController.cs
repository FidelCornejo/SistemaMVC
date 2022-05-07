using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CapaPresentacionAdmin.Controllers
{
    public class MercaderiaController : Controller
    {
        // GET: Mercaderia
        public ActionResult RegistrarEntrada()
        {
            return View();
        }
        public ActionResult ListadoEntrada()
        {
            return View();
        }
        public ActionResult RegistrarSalida()
        {
            return View();
        }
        public ActionResult ListadoSalidas()
        {
            return View();
        }
    }
}