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
    
    public partial class tbclient
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbclient()
        {
            this.tbreservations = new HashSet<tbreservation>();
        }
    
        public int idtbclient { get; set; }
        public string dni { get; set; }
        public string name { get; set; }
        public string surnames { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbreservation> tbreservations { get; set; }
    }
}
