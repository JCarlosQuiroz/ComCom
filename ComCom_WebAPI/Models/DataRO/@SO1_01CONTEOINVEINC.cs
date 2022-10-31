using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.DataRO
{
    public partial class @SO1_01CONTEOINVEINC
    {
        public string Code { get; set; } = null!;
        public string Name { get; set; } = null!;
        public int? U_SO1_NUMPARTIDA { get; set; }
        public string? U_SO1_CODIGOBARRAS { get; set; }
        public decimal? U_SO1_CONTADO { get; set; }
        public string U_SO1_CODIGOERROR { get; set; } = null!;
    }
}
