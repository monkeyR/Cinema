﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CinemaModel
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class CinemaDatabaseEntities : DbContext
    {
        public CinemaDatabaseEntities()
            : base("name=CinemaDatabaseEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Employees> Employees { get; set; }
        public virtual DbSet<Halls> Halls { get; set; }
        public virtual DbSet<Movies> Movies { get; set; }
        public virtual DbSet<MovieSales> MovieSales { get; set; }
        public virtual DbSet<Shifts> Shifts { get; set; }
        public virtual DbSet<Shows> Shows { get; set; }
        public virtual DbSet<Workpositions> Workpositions { get; set; }
        public virtual DbSet<Categories> Categories { get; set; }
        public virtual DbSet<Products> Products { get; set; }
        public virtual DbSet<ProductSales> ProductSales { get; set; }
    }
}
