using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace App_Cine_Peli_Plus.Dto
{
    public class ClienteDto
    {
       
        public string nombre { get; set; }
        public string dpi { get; set; }
        public string correo { get; set; }
        public string tarjeta{ get; set; }




    }

    public class DtosReserva
    {
        public string tiporeserva { get; set; }
        public string voletos { get; set; }
        public string idcliente { get; set; }

        
    }
}