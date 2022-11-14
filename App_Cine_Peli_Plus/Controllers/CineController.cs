using App_Cine_Peli_Plus.Dto;
using App_Cine_Peli_Plus.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace App_Cine_Peli_Plus.Controllers
{
    public class CineController : Controller
    {
        
        // GET: Cine
        public ActionResult Registro()
        {
            return View();
        }
        public ActionResult DtosClientes()
        {
            return View();
        }

        //POST: Cine
        [HttpPost]
        public ActionResult Cliente(ClienteDto objCliente )
        {
            using (Entities ctx = new Entities () )
            {
                CLIENTE Datos = new CLIENTE();
                Datos.NOMBRE_CLIENTE = objCliente.nombre;
                Datos.IDENTIDAD_CLIENTE = objCliente.dpi;
                Datos.EMAIL_CLIENTE = objCliente.correo;
                Datos.TARJETA_CREDITO = objCliente.tarjeta;

                ctx.CLIENTE.Add(Datos);
                ctx.SaveChanges();

            }
        
            return Json(new { result = true }, JsonRequestBehavior.AllowGet);





        }



        public JsonResult ObtenerDatosCliente()
        {
            List<ClienteDto> datosCliente = new List<ClienteDto>();

            using (Entities ctx = new Entities())
            {
                datosCliente = (from dc in ctx.CLIENTE
                                select new ClienteDto
                                {

                                    nombre = dc.NOMBRE_CLIENTE,
                                    dpi = dc.IDENTIDAD_CLIENTE,
                                    correo = dc.EMAIL_CLIENTE,
                                    tarjeta = dc.TARJETA_CREDITO
                                    
                                }).ToList();
            }
            return Json(datosCliente, JsonRequestBehavior.AllowGet);
        }
    }



}
