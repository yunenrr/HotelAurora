//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ModAdministrative.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class tbroom
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbroom()
        {
            this.tbimagerooms = new HashSet<tbimageroom>();
            this.tbreservations = new HashSet<tbreservation>();
        }
    
        public int idtbroom { get; set; }

        [Required(ErrorMessage = "Escriba el nombre de la habitaci�n")]
        [StringLength(65, ErrorMessage = "El tama�o es muy grande")]
        public string nameroom { get; set; }

        [Required(ErrorMessage = "Escriba caracter�sticas sobre la habitaci�n")]
        [StringLength(300, ErrorMessage = "El tama�o es muy grande")]
        public string characteristics { get; set; }

        [Required(ErrorMessage = "Seleccione la disponibilidad")]
        public Nullable<bool> availability { get; set; }

        [Required(ErrorMessage = "Seleccione el tipo de habitaci�n")]
        public int typeroom { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbimageroom> tbimagerooms { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbreservation> tbreservations { get; set; }
        public virtual tbroomtype tbroomtype { get; set; }
    }
}
