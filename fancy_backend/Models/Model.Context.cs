﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace fancy_backend.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class FancyEntities : DbContext
    {
        public FancyEntities()
            : base("name=FancyEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Blog> Blogs { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Contact> Contacts { get; set; }
        public virtual DbSet<Feature_Boxes> Feature_Boxes { get; set; }
        public virtual DbSet<Industry> Industries { get; set; }
        public virtual DbSet<Message> Messages { get; set; }
        public virtual DbSet<Service_Area> Service_Area { get; set; }
        public virtual DbSet<Slider> Sliders { get; set; }
        public virtual DbSet<Testimonials_Slider> Testimonials_Slider { get; set; }
        public virtual DbSet<Feature> Features { get; set; }
        public virtual DbSet<Latest_News> Latest_News { get; set; }
    }
}