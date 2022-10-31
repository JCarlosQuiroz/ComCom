using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.DataRO
{
    public partial class @SO1_01MEMBRESIum
    {
        public string? Code { get; set; }
        public string Name { get; set; } = null!;
        public DateTime? U_SO1_FECHACREACION { get; set; }
        public string? U_SO1_SUCURSAL { get; set; }
        public DateTime? U_SO1_FECHADESDE { get; set; }
        public DateTime? U_SO1_FECHAHASTA { get; set; }
        public string? U_SO1_CLIENTE { get; set; }
        public string U_SO1_ESALTERNO { get; set; } = null!;
        public int? U_SO1_SALDOPUNTOS { get; set; }
        public string U_SO1_ESTATUS { get; set; } = null!;
        public string? U_SO1_TARJETAPUNTOS { get; set; }
        public string? U_SO1_MEMBREPREVIA { get; set; }
    }
}
