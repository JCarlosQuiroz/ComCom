using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.DataRO
{
    public partial class @SO1_01SUCURSALDOSI
    {
        public string Code { get; set; } = null!;
        public int LineId { get; set; }
        public string? Object { get; set; }
        public int? LogInst { get; set; }
        public string? U_SO1_CODIGODOSI { get; set; }
        public string? U_SO1_NOMBREDOSI { get; set; }
        public string U_SO1_TIPODOCU { get; set; } = null!;
        public string? U_SO1_TIPODOCNOM { get; set; }
        public string? U_SO1_PERFILIMPRESI { get; set; }
        public string? U_SO1_PERFILIMPCRED { get; set; }
        public string U_SO1_ACTIVO { get; set; } = null!;
    }
}
