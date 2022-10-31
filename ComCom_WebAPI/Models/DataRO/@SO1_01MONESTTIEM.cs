using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.DataRO
{
    public partial class @SO1_01MONESTTIEM
    {
        public string Code { get; set; } = null!;
        public int LineId { get; set; }
        public string? Object { get; set; }
        public int? LogInst { get; set; }
        public short U_SO1_LINEA { get; set; }
        public int U_SO1_MINUTOS { get; set; }
        public string U_SO1_COLOR { get; set; } = null!;
    }
}
