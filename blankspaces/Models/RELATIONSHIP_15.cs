//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class RELATIONSHIP_15
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RELATIONSHIP_15()
        {
            this.MATERIALBIBLIOGRAFICOes = new HashSet<MATERIALBIBLIOGRAFICO>();
        }
    
        public decimal IDAUTOR { get; set; }
        public decimal IDMATBIBLIO { get; set; }
    
        public virtual AUTOR AUTOR { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MATERIALBIBLIOGRAFICO> MATERIALBIBLIOGRAFICOes { get; set; }
    }
}