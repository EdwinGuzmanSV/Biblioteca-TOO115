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
    
    public partial class DETALLEDEPERSONA
    {
        public int IDDETALLE { get; set; }
        public string IDPERSONA { get; set; }
        public string LUGARDEESTUDIOS { get; set; }
        public Nullable<bool> TRABAJA { get; set; }
        public Nullable<bool> ESTUDIA { get; set; }
        public string NOMBREMADRE { get; set; }
        public string NOMBREPADRE { get; set; }
    
        public virtual PERSONA PERSONA { get; set; }
    }
}
