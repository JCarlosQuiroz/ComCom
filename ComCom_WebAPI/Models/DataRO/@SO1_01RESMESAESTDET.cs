using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.DataRO
{
    public partial class @SO1_01RESMESAESTDET
    {
        public string Code { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string? U_SO1_CODIGO { get; set; }
        public string? U_SO1_CODIGOESTADO { get; set; }
        public string? U_SO1_ESTADODESCRI { get; set; }
        public string U_SO1_ACTIVO { get; set; } = null!;
    }
}
