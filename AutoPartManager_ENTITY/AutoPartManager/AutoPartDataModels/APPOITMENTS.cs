//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AutoPartDataModels
{
    using System;
    using System.Collections.Generic;
    
    public partial class APPOITMENTS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public APPOITMENTS()
        {
            this.SERVICE_WORKS = new HashSet<SERVICE_WORKS>();
        }
    
        public int APPOITMENT_ID { get; set; }
        public System.DateTime APPOITMENT_DATE { get; set; }
        public int CLIENT_ID { get; set; }
        public int CLIENT_CAR_ID { get; set; }
        public string APP_STATUS { get; set; }
        public string COMPLAINS { get; set; }
        public Nullable<double> CAR_MILEAGE { get; set; }
    
        public virtual LOOKUP_ITEMS LOOKUP_ITEMS { get; set; }
        public virtual Clients Clients { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SERVICE_WORKS> SERVICE_WORKS { get; set; }
        public virtual CLIENT_CARS CLIENT_CARS { get; set; }
    }
}
