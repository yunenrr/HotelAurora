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
    
    public partial class tbroom
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbroom()
        {
            this.tbimagerooms = new HashSet<tbimageroom>();
            this.tbreservations = new HashSet<tbreservation>();
        }
    
        public int idtbroom { get; set; }
        public string nameroom { get; set; }
        public string characteristics { get; set; }
        public Nullable<bool> availability { get; set; }
        public int typeroom { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbimageroom> tbimagerooms { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbreservation> tbreservations { get; set; }
        public virtual tbroomtype tbroomtype { get; set; }
    }
}
