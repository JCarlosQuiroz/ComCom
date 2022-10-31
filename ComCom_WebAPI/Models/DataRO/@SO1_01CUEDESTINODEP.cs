using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.DataRO
{
    public partial class @SO1_01CUEDESTINODEP
    {
        public string Code { get; set; } = null!;
        public int LineId { get; set; }
        public string? Object { get; set; }
        public int? LogInst { get; set; }
        public int? U_SO1_CODIGOINTERNO { get; set; }
        public string? U_SO1_CODIGOCUENTA { get; set; }
        public string? U_SO1_NOMBRECUENTA { get; set; }
        public string U_SO1_ACTIVO { get; set; } = null!;
        public string? U_SO1_CODIGOCUENTAMA { get; set; }
        public string? U_SO1_FORMATOCUENTAM { get; set; }
        public string? U_SO1_NOMBRECUENTAMA { get; set; }
        public string? U_SO1_MONEDACUENTAMA { get; set; }
        public string U_SO1_CASACAMBIO { get; set; } = null!;
        public string? U_SO1_REFERENCIA { get; set; }
    }
}
