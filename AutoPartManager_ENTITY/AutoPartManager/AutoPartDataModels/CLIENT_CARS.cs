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
    
    public partial class CLIENT_CARS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CLIENT_CARS()
        {
            this.APPOITMENTS = new HashSet<APPOITMENTS>();
        }
    
        public int CLIENT_CAR_ID { get; set; }
        public int CLIENT_ID { get; set; }
        public int CAR_ID { get; set; }
        public int MODEL_ID { get; set; }
        public Nullable<int> CAR_YEAR { get; set; }
        public string ENGINE_TYPE { get; set; }
        public Nullable<double> ENGINE_SIZE { get; set; }
        public string CAR_REG_NUMB { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<APPOITMENTS> APPOITMENTS { get; set; }
        public virtual Clients Clients { get; set; }
        public virtual LOOKUP_ITEMS LOOKUP_ITEMS { get; set; }
        public virtual Models Models { get; set; }
    }
}
