//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AppUscv.Repository
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblPremiosDocente
    {
        public int id { get; set; }
        public int fkPersonal { get; set; }
        public int fkCatDocumentos { get; set; }
        public Nullable<System.DateTime> fechaObtencionPremio { get; set; }
        public string institucion { get; set; }
        public string nombrePremio { get; set; }
        public string actividadDesempenada { get; set; }
        public Nullable<System.DateTime> FechaInicioPremio { get; set; }
        public Nullable<System.DateTime> FechaFinPremio { get; set; }
        public string tipoPremio { get; set; }
    
        public virtual catDocumentos catDocumentos { get; set; }
        public virtual tblPersonal tblPersonal { get; set; }
    }
}