﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OnlineShop.DAL
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class dbOnlineShopEntities : DbContext
    {
        public dbOnlineShopEntities()
            : base("name=dbOnlineShopEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Tbl_Cart> Tbl_Cart { get; set; }
        public virtual DbSet<Tbl_Cart_Status> Tbl_Cart_Status { get; set; }
        public virtual DbSet<Tbl_Category> Tbl_Category { get; set; }
        public virtual DbSet<Tbl_MemberRole> Tbl_MemberRole { get; set; }
        public virtual DbSet<Tbl_Members> Tbl_Members { get; set; }
        public virtual DbSet<Tbl_Product> Tbl_Product { get; set; }
        public virtual DbSet<Tbl_Roles> Tbl_Roles { get; set; }
        public virtual DbSet<Tbl_ShoppingDetails> Tbl_ShoppingDetails { get; set; }
        public virtual DbSet<Tbl_SlideImage> Tbl_SlideImage { get; set; }
    }
}
