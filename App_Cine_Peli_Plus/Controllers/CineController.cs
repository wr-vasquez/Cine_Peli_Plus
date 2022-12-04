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

        // METODO PARA SETEAR LOS DATOS DE LA TABLA CLIENTE 

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


        //DATOS QUE SE ENVIAN A LA TABLA RESERVA

        //POST: Cine
        [HttpPost]
        public ActionResult Reserva(DtosReserva objReserva)
        {
         
            using (Entities ctx2 = new Entities())
            {
                

        RESERVAS Datos2 = new RESERVAS();
                Datos2.TIPO_RESERVA = objReserva.tiporeserva;
                Datos2.CANTIDAD_VOLETOS = objReserva.voletos;


                ctx2.RESERVAS.Add(Datos2);
                ctx2.SaveChanges();

            }

            return Json(new { result = true }, JsonRequestBehavior.AllowGet);


        }


        //  DATOS QUE SE RECIBEN DE LA BASE DE DATOS //
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
                                    tarjeta = dc.TARJETA_CREDITO,
                                    
                                }).ToList();
            }
            return Json(datosCliente, JsonRequestBehavior.AllowGet);
        }
    }



}
