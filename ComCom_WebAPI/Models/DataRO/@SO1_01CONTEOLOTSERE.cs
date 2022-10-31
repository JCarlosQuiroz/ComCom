using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.DataRO
{
    public partial class @SO1_01CONTEOLOTSERE
    {
        public string? Code { get; set; }
        public string Name { get; set; } = null!;
        public short? U_SO1_NUMPARTIDABASE { get; set; }
        public string? U_SO1_NUMEROARTICULO { get; set; }
        public decimal? U_SO1_CONTADO { get; set; }
        public string? U_SO1_CODIGOESCANEA { get; set; }
        public string U_SO1_TIPOPARTIDA { get; set; } = null!;
        public decimal? U_SO1_EXISTENCIA { get; set; }
        public decimal? U_SO1_DIFERENCIA { get; set; }
    }
}
