//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ShawnaThai_Eiei.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Cooperative
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Cooperative()
        {
            this.Admin_Cooperative = new HashSet<Admin_Cooperative>();
            this.Farmers = new HashSet<Farmer>();
        }
    
        public string Coop_Name { get; set; }
        public string Coop_Tel { get; set; }
        public string Coop_Latitude { get; set; }
        public string Coop_Longitude { get; set; }
        public string Coop_A_No { get; set; }
        public string Coop_A_Sup { get; set; }
        public string Coop_A_District { get; set; }
        public string Coop_A_Province { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Admin_Cooperative> Admin_Cooperative { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Farmer> Farmers { get; set; }
    }
}
