﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SummativeAssessment_PRG522_7595_DuncanBarnard.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class SummativeAssessment_7595_LoginEntities1 : DbContext
    {
        public SummativeAssessment_7595_LoginEntities1()
            : base("name=SummativeAssessment_7595_LoginEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<loginRegister> loginRegisters { get; set; }
    }
}
