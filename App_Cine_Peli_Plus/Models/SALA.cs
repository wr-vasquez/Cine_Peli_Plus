//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace App_Cine_Peli_Plus.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class SALA
    {
        public decimal ID_SALA { get; set; }
        public string NUMERO_SALA { get; set; }
        public string ASIENTO { get; set; }
        public decimal ID_RESERVA { get; set; }
    
        public virtual RESERVAS RESERVAS { get; set; }
    }
}
