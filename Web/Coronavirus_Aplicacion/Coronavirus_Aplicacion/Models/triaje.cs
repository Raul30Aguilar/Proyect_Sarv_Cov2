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
    
    public partial class triaje
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public triaje()
        {
            this.estado_ciudadano = new HashSet<estado_ciudadano>();
        }
    
        public int idtriaje { get; set; }
        public bool question1 { get; set; }
        public bool question2 { get; set; }
        public bool question3 { get; set; }
        public bool question4 { get; set; }
        public bool question5 { get; set; }
        public bool question_obesidad { get; set; }
        public bool question_enfermedad { get; set; }
        public bool question_diabetes { get; set; }
        public bool question_hipertension { get; set; }
        public bool question_cancer { get; set; }
        public bool question2_adulto { get; set; }
        public bool question2_nino { get; set; }
        public bool question2_gestante { get; set; }
        public bool question2_cronica { get; set; }
        public int persona { get; set; }
        public System.DateTime fecha { get; set; }
        public int docciudadano { get; set; }
    
        public virtual ciudadano ciudadano { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<estado_ciudadano> estado_ciudadano { get; set; }
    }
}
