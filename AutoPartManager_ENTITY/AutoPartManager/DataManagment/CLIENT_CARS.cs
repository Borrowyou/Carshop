//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataManagment
{
    using System;
    using System.Collections.Generic;
    
    public partial class CLIENT_CARS
    {
        public int CLIENT_CAR_ID { get; set; }
        public int CLIENT_ID { get; set; }
        public int CAR_ID { get; set; }
        public int MODEL_ID { get; set; }
        public Nullable<int> CAR_YEAR { get; set; }
        public string ENGINE_TYPE { get; set; }
        public Nullable<double> ENGINE_SIZE { get; set; }
    
        public virtual Clients Clients { get; set; }
        public virtual Models Models { get; set; }
    }
}
