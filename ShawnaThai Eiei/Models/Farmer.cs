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
    
    public partial class Farmer
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Farmer()
        {
            this.Product_Rice = new HashSet<Product_Rice>();
        }
    
        public string Farmer_IDCard { get; set; }
        public string Farmer_Name { get; set; }
        public string Farmer_LastName { get; set; }
        public string Farmer_Tel { get; set; }
        public string Farmer_A_No { get; set; }
        public string Farmer_A_Sup { get; set; }
        public string Farmer_A_District { get; set; }
        public string Farmer_A_Province { get; set; }
        public string Coop_Name { get; set; }
    
        public virtual Cooperative Cooperative { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Product_Rice> Product_Rice { get; set; }
    }
}
