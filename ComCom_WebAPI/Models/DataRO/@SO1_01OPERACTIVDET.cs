using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.DataRO
{
    public partial class @SO1_01OPERACTIVDET
    {
        public string Code { get; set; } = null!;
        public int LineId { get; set; }
        public string? Object { get; set; }
        public int? LogInst { get; set; }
        public string U_SO1_CODOPERACION { get; set; } = null!;
        public string U_SO1_NOMOPERACION { get; set; } = null!;
        public string U_SO1_CODMODULO { get; set; } = null!;
        public string U_SO1_NOMMODULO { get; set; } = null!;
        public string U_SO1_ACTIVO { get; set; } = null!;
        public string U_SO1_DOMICILIO { get; set; } = null!;
        public string U_SO1_DOMICILIODEFEC { get; set; } = null!;
    }
}
