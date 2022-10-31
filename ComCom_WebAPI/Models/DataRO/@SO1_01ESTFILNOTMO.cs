using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.DataRO
{
    public partial class @SO1_01ESTFILNOTMO
    {
        public string Code { get; set; } = null!;
        public int LineId { get; set; }
        public string? Object { get; set; }
        public int? LogInst { get; set; }
        public string? U_SO1_ESTACION { get; set; }
        public string? U_SO1_DESCESTACION { get; set; }
        public string U_SO1_ACTIVO { get; set; } = null!;
    }
}
