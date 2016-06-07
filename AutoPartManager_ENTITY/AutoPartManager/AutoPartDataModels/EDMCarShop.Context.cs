﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class CarShopEntities : DbContext
    {
        public CarShopEntities()
            : base("name=CarShopEntities")
        {
            this.Configuration.LazyLoadingEnabled = false;
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<APPOITMENTS> APPOITMENTS { get; set; }
        public virtual DbSet<Cars> Cars { get; set; }
        public virtual DbSet<CLIENT_CARS> CLIENT_CARS { get; set; }
        public virtual DbSet<Clients> Clients { get; set; }
        public virtual DbSet<EMPLOYEES> EMPLOYEES { get; set; }
        public virtual DbSet<EMPLOYEES_SERVICE_WORKS> EMPLOYEES_SERVICE_WORKS { get; set; }
        public virtual DbSet<LOOKUP_ITEMS> LOOKUP_ITEMS { get; set; }
        public virtual DbSet<Models> Models { get; set; }
        public virtual DbSet<Parts> Parts { get; set; }
        public virtual DbSet<PARTS_LINK> PARTS_LINK { get; set; }
        public virtual DbSet<PROVIDER_CATEGORIES> PROVIDER_CATEGORIES { get; set; }
        public virtual DbSet<REPAIR_SERVICES> REPAIR_SERVICES { get; set; }
        public virtual DbSet<SERVICE_WORK_PARTS> SERVICE_WORK_PARTS { get; set; }
        public virtual DbSet<SERVICE_WORKS> SERVICE_WORKS { get; set; }
        public virtual DbSet<SERVICES> SERVICES { get; set; }
        public virtual DbSet<SUB_CATEGORIES> SUB_CATEGORIES { get; set; }
        public virtual DbSet<SUB_MODELS> SUB_MODELS { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<V_Car_Model_Part> V_Car_Model_Part { get; set; }
        public virtual DbSet<V_Cars_Models> V_Cars_Models { get; set; }
        public virtual DbSet<VIEW_APPOITMENT_CLIENT_SUMS> VIEW_APPOITMENT_CLIENT_SUMS { get; set; }
        public virtual DbSet<VIEW_APPOITMENT_INVOICE_DATA> VIEW_APPOITMENT_INVOICE_DATA { get; set; }
        public virtual DbSet<VIEW_CLIENT_CARS> VIEW_CLIENT_CARS { get; set; }
        public virtual DbSet<GENERATORS> GENERATORS { get; set; }
    
        [DbFunction("CarShopEntities", "FUN_INVOICE_DATA_BY_APP_ID")]
        public virtual IQueryable<FUN_INVOICE_DATA_BY_APP_ID_Result> FUN_INVOICE_DATA_BY_APP_ID(Nullable<int> aPPOITMENT_ID)
        {
            var aPPOITMENT_IDParameter = aPPOITMENT_ID.HasValue ?
                new ObjectParameter("APPOITMENT_ID", aPPOITMENT_ID) :
                new ObjectParameter("APPOITMENT_ID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<FUN_INVOICE_DATA_BY_APP_ID_Result>("[CarShopEntities].[FUN_INVOICE_DATA_BY_APP_ID](@APPOITMENT_ID)", aPPOITMENT_IDParameter);
        }
    
        [DbFunction("CarShopEntities", "FUN_INVOICE_TOTAL_SUM_BY_APP_ID")]
        public virtual IQueryable<FUN_INVOICE_TOTAL_SUM_BY_APP_ID_Result> FUN_INVOICE_TOTAL_SUM_BY_APP_ID(Nullable<int> aPPOITMENT_ID)
        {
            var aPPOITMENT_IDParameter = aPPOITMENT_ID.HasValue ?
                new ObjectParameter("APPOITMENT_ID", aPPOITMENT_ID) :
                new ObjectParameter("APPOITMENT_ID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<FUN_INVOICE_TOTAL_SUM_BY_APP_ID_Result>("[CarShopEntities].[FUN_INVOICE_TOTAL_SUM_BY_APP_ID](@APPOITMENT_ID)", aPPOITMENT_IDParameter);
        }
    
        [DbFunction("CarShopEntities", "FUN_YEARS_BETWEEN_LIST")]
        public virtual IQueryable<FUN_YEARS_BETWEEN_LIST_Result> FUN_YEARS_BETWEEN_LIST(Nullable<int> from, Nullable<int> to)
        {
            var fromParameter = from.HasValue ?
                new ObjectParameter("From", from) :
                new ObjectParameter("From", typeof(int));
    
            var toParameter = to.HasValue ?
                new ObjectParameter("To", to) :
                new ObjectParameter("To", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<FUN_YEARS_BETWEEN_LIST_Result>("[CarShopEntities].[FUN_YEARS_BETWEEN_LIST](@From, @To)", fromParameter, toParameter);
        }
    
        public virtual int SP_GEN_ID(string gENERATOR_NAME, Nullable<int> gENERATOR_STEP, ObjectParameter nEW_VALUE)
        {
            var gENERATOR_NAMEParameter = gENERATOR_NAME != null ?
                new ObjectParameter("GENERATOR_NAME", gENERATOR_NAME) :
                new ObjectParameter("GENERATOR_NAME", typeof(string));
    
            var gENERATOR_STEPParameter = gENERATOR_STEP.HasValue ?
                new ObjectParameter("GENERATOR_STEP", gENERATOR_STEP) :
                new ObjectParameter("GENERATOR_STEP", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_GEN_ID", gENERATOR_NAMEParameter, gENERATOR_STEPParameter, nEW_VALUE);
        }
    
        [DbFunction("CarShopEntities", "FUN_CALC_APP_SUM_BY_APP_ID")]
        public virtual IQueryable<FUN_CALC_APP_SUM_BY_APP_ID_Result> FUN_CALC_APP_SUM_BY_APP_ID(Nullable<int> aPPOITMENT_ID)
        {
            var aPPOITMENT_IDParameter = aPPOITMENT_ID.HasValue ?
                new ObjectParameter("APPOITMENT_ID", aPPOITMENT_ID) :
                new ObjectParameter("APPOITMENT_ID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<FUN_CALC_APP_SUM_BY_APP_ID_Result>("[CarShopEntities].[FUN_CALC_APP_SUM_BY_APP_ID](@APPOITMENT_ID)", aPPOITMENT_IDParameter);
        }
    }
}
