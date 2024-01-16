﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DL
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class MercanciasEntities : DbContext
    {
        public MercanciasEntities()
            : base("name=MercanciasEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Producto> Productos { get; set; }
        public virtual DbSet<Tipo> Tipoes { get; set; }
    
        public virtual int ProductosAdd(string nombre, Nullable<int> idTipo, Nullable<decimal> precio)
        {
            var nombreParameter = nombre != null ?
                new ObjectParameter("Nombre", nombre) :
                new ObjectParameter("Nombre", typeof(string));
    
            var idTipoParameter = idTipo.HasValue ?
                new ObjectParameter("IdTipo", idTipo) :
                new ObjectParameter("IdTipo", typeof(int));
    
            var precioParameter = precio.HasValue ?
                new ObjectParameter("Precio", precio) :
                new ObjectParameter("Precio", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ProductosAdd", nombreParameter, idTipoParameter, precioParameter);
        }
    }
}
