using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.DataRO
{
    public partial class @SO1_01CATAACCIMONI
    {
        public string Code { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string? U_SO1_TIPO { get; set; }
        public string? U_SO1_DEPENDENCIA { get; set; }
        public string? U_SO1_OBLIGATORIA { get; set; }
        public string? U_SO1_CODIGOFUNCION { get; set; }
    }
}
