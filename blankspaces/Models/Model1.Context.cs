﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace blankspaces.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class BibliotecaEntities1 : DbContext
    {
        public BibliotecaEntities1()
            : base("name=BibliotecaEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<AUTOR> AUTORs { get; set; }
        public virtual DbSet<CATERGORIA> CATERGORIAs { get; set; }
        public virtual DbSet<DEPARTAMENTO> DEPARTAMENTOes { get; set; }
        public virtual DbSet<DETALLEDEPERSONA> DETALLEDEPERSONAs { get; set; }
        public virtual DbSet<DOCUMENTOLOCALIDAD> DOCUMENTOLOCALIDADs { get; set; }
        public virtual DbSet<MATERIALBIBLIOGRAFICO> MATERIALBIBLIOGRAFICOes { get; set; }
        public virtual DbSet<MENU> MENUs { get; set; }
        public virtual DbSet<MUNICIPIO> MUNICIPIOs { get; set; }
        public virtual DbSet<PENALIZACION> PENALIZACIONs { get; set; }
        public virtual DbSet<PERSONA> PERSONAs { get; set; }
        public virtual DbSet<PRESTAMO> PRESTAMOes { get; set; }
        public virtual DbSet<RELATIONSHIP_15> RELATIONSHIP_15 { get; set; }
        public virtual DbSet<ROL> ROLs { get; set; }
        public virtual DbSet<TIPODOCUMENTO> TIPODOCUMENTOes { get; set; }
        public virtual DbSet<USUARIO> USUARIOs { get; set; }
    }
}
