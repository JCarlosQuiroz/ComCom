using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.DataRO
{
    public partial class @SO1_01ERRORARCHIVO
    {
        public string? Code { get; set; }
        public string Name { get; set; } = null!;
        public string? U_SO1_ARCHIVO { get; set; }
        public string? U_SO1_ESTACION { get; set; }
        public string? U_SO1_TIPOOPERACION { get; set; }
        public string? U_SO1_IDENTIFICADOR { get; set; }
        public string? U_SO1_ERROR { get; set; }
        public string U_SO1_TIPOARCHIVO { get; set; } = null!;
        public DateTime? U_SO1_FECHA { get; set; }
        public short? U_SO1_HORA { get; set; }
        public string U_SO1_NOTIFICADO { get; set; } = null!;
    }
}
