﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Culqi_Online.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class culqi_dbEntities : DbContext
    {
        public culqi_dbEntities()
            : base("name=culqi_dbEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Banco> Banco { get; set; }
        public virtual DbSet<Categoria> Categoria { get; set; }
        public virtual DbSet<Comercio> Comercio { get; set; }
        public virtual DbSet<Cuenta> Cuenta { get; set; }
        public virtual DbSet<Deposito> Deposito { get; set; }
        public virtual DbSet<Detalle_Deposito> Detalle_Deposito { get; set; }
        public virtual DbSet<Detalle_Venta> Detalle_Venta { get; set; }
        public virtual DbSet<Estado_Efectivo> Estado_Efectivo { get; set; }
        public virtual DbSet<Estado_Tarjeta> Estado_Tarjeta { get; set; }
        public virtual DbSet<Lugar> Lugar { get; set; }
        public virtual DbSet<Marca> Marca { get; set; }
        public virtual DbSet<Medio_Pago> Medio_Pago { get; set; }
        public virtual DbSet<Tipo_Cuenta> Tipo_Cuenta { get; set; }
        public virtual DbSet<Tipo_Documento> Tipo_Documento { get; set; }
        public virtual DbSet<Tipo_Moneda> Tipo_Moneda { get; set; }
        public virtual DbSet<Tipo_Usuario> Tipo_Usuario { get; set; }
        public virtual DbSet<Usuario> Usuario { get; set; }
        public virtual DbSet<Venta> Venta { get; set; }
        public virtual DbSet<Venta_Efectivo> Venta_Efectivo { get; set; }
        public virtual DbSet<Venta_Tarjeta> Venta_Tarjeta { get; set; }
    }
}
