using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.DataRO
{
    public partial class @SO1_01ESTAREAIMP
    {
        public string Code { get; set; } = null!;
        public int LineId { get; set; }
        public string? Object { get; set; }
        public int? LogInst { get; set; }
        public string? U_SO1_NOMBREIMP { get; set; }
        public string? U_SO1_AREAIMP { get; set; }
        public string? U_SO1_PREIMP { get; set; }
        public string? U_SO1_TIPOIMP { get; set; }
        public short? U_SO1_COPIAS { get; set; }
        public string? U_SO1_NOMBREREP { get; set; }
        public string? U_SO1_CODIGODOC { get; set; }
    }
}
