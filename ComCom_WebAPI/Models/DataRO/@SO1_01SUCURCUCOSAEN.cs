using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.DataRO
{
    public partial class @SO1_01SUCURCUCOSAEN
    {
        public string Code { get; set; } = null!;
        public int LineId { get; set; }
        public string? Object { get; set; }
        public int? LogInst { get; set; }
        public string U_SO1_TIPOMOVIMIENTO { get; set; } = null!;
        public string? U_SO1_DESCMOVIMIENTO { get; set; }
        public string? U_SO1_CODIGOCONCEPTO { get; set; }
        public string? U_SO1_DESCRICONCEPTO { get; set; }
        public string? U_SO1_CODIGOCUENTA { get; set; }
        public string? U_SO1_FORMATOCUENTA { get; set; }
        public string? U_SO1_NOMBRECUENTA { get; set; }
    }
}
