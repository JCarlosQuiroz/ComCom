using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.DataRO
{
    public partial class @SO1_01TARJETAPUNTFP
    {
        public string Code { get; set; } = null!;
        public int LineId { get; set; }
        public string? Object { get; set; }
        public int? LogInst { get; set; }
        public string? U_SO1_CODIGOFOPA { get; set; }
        public string? U_SO1_NOMBREFOPA { get; set; }
        public string U_SO1_SELECCIONADA { get; set; } = null!;
    }
}
