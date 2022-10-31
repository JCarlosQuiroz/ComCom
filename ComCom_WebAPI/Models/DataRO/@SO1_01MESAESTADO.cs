using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.DataRO
{
    public partial class @SO1_01MESAESTADO
    {
        public string Code { get; set; } = null!;
        public int LineId { get; set; }
        public string? Object { get; set; }
        public int? LogInst { get; set; }
        public string? U_SO1_ESTADOMESA { get; set; }
        public string? U_SO1_IMAGENMESA { get; set; }
        public string? U_SO1_DESCRESTADO { get; set; }
    }
}
