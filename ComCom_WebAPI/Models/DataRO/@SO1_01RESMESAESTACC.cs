using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.DataRO
{
    public partial class @SO1_01RESMESAESTACC
    {
        public string Code { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string? U_SO1_CODIGO { get; set; }
        public string? U_SO1_CODIGOESTADO { get; set; }
        public string? U_SO1_CODIGOACCION { get; set; }
        public string? U_SO1_ACCIONDESCRI { get; set; }
        public string U_SO1_ACTIVO { get; set; } = null!;
        public string? U_SO1_CAMBIOESTADO { get; set; }
        public string? U_SO1_IMAGEN { get; set; }
        public int? U_SO1_PRIORIDAD { get; set; }
    }
}
