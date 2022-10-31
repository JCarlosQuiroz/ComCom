using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.DataRO
{
    public partial class @SO1_01SUCURSALAREA
    {
        public string Code { get; set; } = null!;
        public int LineId { get; set; }
        public string? Object { get; set; }
        public int? LogInst { get; set; }
        public string? U_SO1_NOMBRE { get; set; }
        public string? U_SO1_IMAGENBASE { get; set; }
        public string? U_SO1_IMAGENACTUAL { get; set; }
        public int? U_SO1_NUMPARTIDA { get; set; }
    }
}
