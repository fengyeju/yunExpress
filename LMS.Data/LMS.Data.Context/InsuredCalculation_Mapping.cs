//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LMS.Data.Context
{
    #pragma warning disable 1573
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Common;
    using System.Data.Entity;
    using System.Data.Entity.ModelConfiguration;
    using System.Data.Entity.Infrastructure;
    
    using LMS.Data.Entity;
    
    
    internal partial class InsuredCalculation_Mapping : EntityTypeConfiguration<InsuredCalculation>
    {
        public InsuredCalculation_Mapping()
        {                        
              this.HasKey(t => t.InsuredID);        
              this.ToTable("InsuredCalculations");
              this.Property(t => t.InsuredID).HasColumnName("InsuredID").HasDatabaseGeneratedOption(new Nullable<DatabaseGeneratedOption>(DatabaseGeneratedOption.None));
              this.Property(t => t.InsuredName).HasColumnName("InsuredName").HasMaxLength(50);
              this.Property(t => t.InsuredCalculation1).HasColumnName("InsuredCalculation").HasMaxLength(100);
              this.Property(t => t.Status).HasColumnName("Status");
              this.Property(t => t.CreatedOn).HasColumnName("CreatedOn");
              this.Property(t => t.CreatedBy).HasColumnName("CreatedBy").HasMaxLength(50);
              this.Property(t => t.LastUpdatedOn).HasColumnName("LastUpdatedOn");
              this.Property(t => t.LastUpdatedBy).HasColumnName("LastUpdatedBy").HasMaxLength(50);
         }
    }
}
