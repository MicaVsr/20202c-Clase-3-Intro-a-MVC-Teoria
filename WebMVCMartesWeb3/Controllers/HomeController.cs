using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebMVCMartesWeb3.Controllers
{
    public class HomeController : Controller
    {

        // http://midominio/home

        public ActionResult Bienvenido(string id)
        {
            //string mensaje = "Bienvenidos";

            List<string> nombres = new List<string>() { "Alberto", "Juana", "Sebas", "Belen", "Joaco" };

            ViewBag.MiId = id;

            return View(nombres);
        }

        public ActionResult Index(string id)
        {
          
            return View();

            //return View("Inicio");
 
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}