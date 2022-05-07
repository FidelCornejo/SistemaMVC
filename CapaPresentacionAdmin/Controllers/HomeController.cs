using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CapaEntidad;
using CapaNegocio;




namespace CapaPresentacionAdmin.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Configuraciones()
        {
            return View();
        }  public ActionResult Usuarios()
        {
            return View();
        }
        [HttpGet]
        public JsonResult ListarUsuarios()
        {
        
            List<Usuario> oLista = new List<Usuario>();
            oLista = new CN_Usuarios().Listar();
            //return Json(oLista, JsonRequestBehavior.AllowGet);
            return Json(new { data = oLista }, JsonRequestBehavior.AllowGet);//cambiamos la vista para dataTables
        }





        [HttpPost]
        public JsonResult GuardarUsuario(Usuario objeto)
        {
            object resultado;
            string mensaje = string.Empty;
            if (objeto.IdUsuario == 0)//verifica si es un usuario nuevo pasado por objeto
            {
                resultado = new CN_Usuarios().Registrar(objeto, out mensaje);//devuelve el Id del usuario
            }
            else
            {
                resultado = new CN_Usuarios().Editar(objeto, out mensaje);// edita al usurio 
            }
            //devuelve un json con el resultado de los anteriores if llamado igual resultado
            return Json(new { resultado = resultado, mensaje=mensaje }, JsonRequestBehavior.AllowGet);//cambiamos la vista para dataTables

        }



        [HttpPost]
        public JsonResult EliminarUsuario(int id)
        {
            bool respuesta = false;
            string mensaje = string.Empty;

            respuesta = new CN_Usuarios().Eliminar(id, out mensaje);
            return Json(new { resultado = respuesta, mensaje = mensaje }, JsonRequestBehavior.AllowGet);
        }
        //public ActionResult About()
        //{
        //    ViewBag.Message = "Your application description page.";
        //    return View();
        //}

        //public ActionResult Contact()
        //{
        //    ViewBag.Message = "Your contact page.";
        //    return View();
        //}
    }
}