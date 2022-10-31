using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.DataRO
{
    public partial class @SO1_01HORA
    {
        public string Code { get; set; } = null!;
        public int LineId { get; set; }
        public string? Object { get; set; }
        public int? LogInst { get; set; }
        public int U_SO1_LINEAORDEN { get; set; }
        public string U_SO1_HORA { get; set; } = null!;
        public string U_SO1_FORMATO { get; set; } = null!;
    }
}
