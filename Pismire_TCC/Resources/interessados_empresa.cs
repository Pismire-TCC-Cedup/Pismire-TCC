//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Pismire_TCC.Resources
{
    using System;
    using System.Collections.Generic;
    
    public partial class interessados_empresa
    {
        public int idInteressadosEmpresa { get; set; }
        public string FK_usuario_empresa { get; set; }
        public int FK_curriculo { get; set; }
    
        public virtual curriculo curriculo { get; set; }
        public virtual usuario_empresa usuario_empresa { get; set; }
    }
}
