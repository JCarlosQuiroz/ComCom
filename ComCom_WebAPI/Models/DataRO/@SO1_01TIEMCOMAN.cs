using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.DataRO
{
    public partial class @SO1_01TIEMCOMAN
    {
        public string Code { get; set; } = null!;
        public int LineId { get; set; }
        public string? Object { get; set; }
        public int? LogInst { get; set; }
        public short U_SO1_ORDEN { get; set; }
        public string U_SO1_NOMBRE { get; set; } = null!;
        public string U_SO1_COLOR { get; set; } = null!;
    }
}
