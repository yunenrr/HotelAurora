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

    public partial class tbuser
    {
        public int idtbuser { get; set; }

        [Required(ErrorMessage = "Ingrese el nombre de usuario")]
        [StringLength(65, ErrorMessage = "El tama�o m�ximo es de 50 car�cteres.")]
        public string nametbuser { get; set; }

        [Required(ErrorMessage = "Ingrese la contrase�a")]
        [StringLength(65, ErrorMessage = "El tama�o m�ximo es de 25 car�cteres.")]
        public string password { get; set; }
        public int idtbrole { get; set; }
    
        public virtual tbrole tbrole { get; set; }
    }
}
