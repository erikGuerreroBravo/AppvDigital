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
    
    public partial class tblDocumentacionRHFueraUT
    {
        public Nullable<int> fkPersonal { get; set; }
        public Nullable<int> fkCatDocumentos { get; set; }
        public string periodo { get; set; }
        public string puestoDesempeñado { get; set; }
        public string institucion { get; set; }
        public Nullable<System.DateTime> fechainicio { get; set; }
        public Nullable<System.DateTime> fechafin { get; set; }
        public int id { get; set; }
        public string actividadesRealizadas { get; set; }
        public string motivoConclucion { get; set; }
        public string tipoPersona { get; set; }
    
        public virtual catDocumentos catDocumentos { get; set; }
        public virtual tblPersonal tblPersonal { get; set; }
    }
}