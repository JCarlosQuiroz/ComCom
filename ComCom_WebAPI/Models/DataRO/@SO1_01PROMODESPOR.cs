using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.DataRO
{
    public partial class @SO1_01PROMODESPOR
    {
        public string Code { get; set; } = null!;
        public string Name { get; set; } = null!;
        public short? U_SO1_PROMOCION { get; set; }
        public string? U_SO1_PROMOCADENA { get; set; }
        public decimal? U_SO1_DESCUENTO1 { get; set; }
        public decimal? U_SO1_DESCUENTO2 { get; set; }
        public string U_SO1_MANTENERDESC { get; set; } = null!;
        public string U_SO1_APLICARESCAN { get; set; } = null!;
    }
}
