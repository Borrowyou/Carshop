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
    
    public partial class Parts
    {
        public int Part_ID { get; set; }
        public string part_name { get; set; }
        public Nullable<double> part_price { get; set; }
        public string part_details { get; set; }
        public string part_manuf { get; set; }
        public Nullable<int> Car_ID { get; set; }
        public Nullable<int> Model_ID { get; set; }
        public Nullable<int> CATEGORY_ID { get; set; }
        public byte[] IMG { get; set; }
    
        public virtual Cars Cars { get; set; }
        public virtual Models Models { get; set; }
    }
}
