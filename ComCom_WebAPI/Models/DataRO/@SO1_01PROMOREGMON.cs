using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.DataRO
{
    public partial class @SO1_01PROMOREGMON
    {
        public string Code { get; set; } = null!;
        public string Name { get; set; } = null!;
        public short? U_SO1_PROMOCION { get; set; }
        public string? U_SO1_PROMOCADENA { get; set; }
        public string U_SO1_AGREGARARTAUTO { get; set; } = null!;
        public string U_SO1_REGALOPRECIO1 { get; set; } = null!;
        public string U_SO1_PORCADAXMONTO { get; set; } = null!;
        public decimal? U_SO1_PORCENTAJEPRO { get; set; }
        public string? U_SO1_MENSAJEPROXIM { get; set; }
        public string? U_SO1_MONEDA { get; set; }
        public decimal? U_SO1_MONTOREGALO { get; set; }
        public decimal? U_SO1_CANTIDADREGAL { get; set; }
    }
}
