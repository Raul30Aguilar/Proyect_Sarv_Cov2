//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Coronavirus_Aplicacion.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class rol_operacion
    {
        public int id { get; set; }
        public Nullable<int> idrol { get; set; }
        public Nullable<int> idoperacion { get; set; }
    
        public virtual operacion operacion { get; set; }
        public virtual rol rol { get; set; }
    }
}
