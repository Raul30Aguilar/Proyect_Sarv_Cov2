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
    
    public partial class CIUDADANO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CIUDADANO()
        {
            this.ESTADO_CIUDADANO = new HashSet<ESTADO_CIUDADANO>();
            this.TRIAJE = new HashSet<TRIAJE>();
        }
    
        public int idCiudadano { get; set; }
        public string nomCiudadano { get; set; }
        public string apeCiudadano { get; set; }
        public string celCiudadano { get; set; }
        public int edadCiudadano { get; set; }
        public string docCiudadano { get; set; }
        public string dirCiudadano { get; set; }
        public int idDepartamento { get; set; }
        public int idProv { get; set; }
        public int idDistrito { get; set; }
        public int idTipoDocumento { get; set; }
        public System.DateTime fecha { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ESTADO_CIUDADANO> ESTADO_CIUDADANO { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TRIAJE> TRIAJE { get; set; }
        public virtual DEPARTAMENTO DEPARTAMENTO { get; set; }
        public virtual DISTRITO DISTRITO { get; set; }
        public virtual PROVINCIA PROVINCIA { get; set; }
        public virtual TIPO_DOCUMENTO TIPO_DOCUMENTO { get; set; }
    }
}
