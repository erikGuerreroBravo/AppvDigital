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
    
    public partial class tblTutorias
    {
        public int id { get; set; }
        public Nullable<int> fkProgramaEducativo { get; set; }
        public Nullable<int> NumeroEstudiantes { get; set; }
        public Nullable<System.DateTime> fechaInicio { get; set; }
        public Nullable<System.DateTime> fechaTermino { get; set; }
        public string tutoria { get; set; }
        public string tipo { get; set; }
        public string estadoTutoria { get; set; }
        public Nullable<int> fkPersonal { get; set; }
        public string nombreEstudiante { get; set; }
    
        public virtual catProgramaEducativo catProgramaEducativo { get; set; }
        public virtual tblPersonal tblPersonal { get; set; }
    }
}
