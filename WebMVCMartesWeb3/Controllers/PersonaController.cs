using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ServiceLayer;


namespace WebMVCMartesWeb3.Controllers
{
    public class PersonaController : Controller
    {
        PersonaService ps = new PersonaService();
        // GET: Empleado
        public ActionResult Listar()
        {
            

            List <Persona> personas = ps.ListarTodas();

            return View(personas);
        }

        [HttpGet]
        public ActionResult CrearNuevo()
        {
            return View();
        
        }

        //[HttpPost]
        //public ActionResult CrearNuevo(FormCollection form)
        //{
        //    Persona persona = new Persona();

        //    persona.Nombre = form["Nombre"];
        //    persona.Apellido = form["Apellido"];

        //    //persona.Nombre = Request["Nombre"];

        //    ps.AgregarPersona(persona);

        //    return RedirectToAction("Listar");

        //   // return View();
        //}

        [HttpPost]
        public ActionResult CrearNuevo(Persona persona)
        {
            //Persona persona = new Persona();
            
            //persona.Nombre = form["Nombre"];
            //persona.Apellido = form["Apellido"];

            //persona.Nombre = Request["Nombre"];



            ps.AgregarPersona(persona);

            return RedirectToAction("Listar");

            // return View();
        }







    }
}