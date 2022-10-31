using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.DataRO
{
    public partial class @SO1_01COMBOVENTAAMB
    {
        public string Code { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string? U_SO1_CODIGO { get; set; }
        public int? U_SO1_CODIGOAMBITO { get; set; }
        public string? U_SO1_NOMBREAMBITO { get; set; }
        public decimal? U_SO1_CANTIDAD { get; set; }
        public string U_SO1_REGALO { get; set; } = null!;
        public string? U_SO1_IMAGEN { get; set; }
    }
}
