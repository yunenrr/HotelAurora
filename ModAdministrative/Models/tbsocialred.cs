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

    public partial class tbsocialred
    {
        public int idtbsocialred { get; set; }

        [Required(ErrorMessage ="Ingrese el nombre de la red social")]
        [StringLength(65, ErrorMessage = "El tama�o m�ximo es de 65 car�cteres.")]
        public string socialred { get; set; }

        [Required(ErrorMessage = "Ingrese la URL de la red social")]
        [StringLength(65, ErrorMessage = "El tama�o m�ximo es de 65 car�cteres.")]
        public string urlsocialred { get; set; }
    }
}
