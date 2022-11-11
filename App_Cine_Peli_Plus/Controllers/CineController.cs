using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace App_Cine_Peli_Plus.Controllers
{
    public class CineController : Controller
    {
        public class Cliente
        {
            public string Nombre { get; set; }
            public string Identidad { get; set; }
            public string Email { get; set; }
            public string Tarjeta { get; set; }
        }
        // GET: Cine
        public ActionResult Registro()
        {
            return View();
        }

        //POST: Cine
        [HttpPost]
        public ActionResult Registro(Cliente c, string nombre, string identidad, string email, string tarjeta)
        {
            c.Nombre = nombre;
            c.Identidad = identidad;
            c.Email = email;
            c.Tarjeta = tarjeta;

            ViewBag.Nombre = c.Nombre;
            ViewBag.Identidad = c.Identidad;
            ViewBag.Email = c.Email;
            ViewBag.Tarjeta = c.Tarjeta;
            return View();



        }
    }
}
