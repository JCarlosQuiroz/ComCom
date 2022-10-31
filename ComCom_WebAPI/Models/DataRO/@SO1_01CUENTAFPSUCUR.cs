using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.DataRO
{
    public partial class @SO1_01CUENTAFPSUCUR
    {
        public string Code { get; set; } = null!;
        public int LineId { get; set; }
        public string? Object { get; set; }
        public int? LogInst { get; set; }
        public string? U_SO1_CODIGOFOPA { get; set; }
        public string? U_SO1_NOMBREFOPA { get; set; }
        public string? U_SO1_CODIGOCUENTA { get; set; }
        public string? U_SO1_FORMATOCUENTA { get; set; }
        public string? U_SO1_NOMBRECUENTA { get; set; }
        public string? U_SO1_POLIPOLIZACOMI { get; set; }
        public string U_SO1_APLIDEVOLU { get; set; } = null!;
        public string? U_SO1_RFCEMICTABENE { get; set; }
        public string? U_SO1_CTABENEFICIA { get; set; }
    }
}
