//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace blankspaces.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class PRESTAMO
    {
        public int IDPRESTAMO { get; set; }
        public Nullable<decimal> IDMATBIBLIO { get; set; }
        public string IDUSUARIO { get; set; }
        public string FECHADEPRESTAMO { get; set; }
        public string FECHADEENTREGA { get; set; }
    
        public virtual MATERIALBIBLIOGRAFICO MATERIALBIBLIOGRAFICO { get; set; }
        public virtual USUARIO USUARIO { get; set; }
    }
}
