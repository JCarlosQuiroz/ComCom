using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.DataRO
{
    public partial class @SO1_01PROMOAXB
    {
        public string Code { get; set; } = null!;
        public string Name { get; set; } = null!;
        public short? U_SO1_PROMOCION { get; set; }
        public string? U_SO1_PROMOCADENA { get; set; }
        public decimal? U_SO1_PIEZASTOTALES { get; set; }
        public decimal? U_SO1_PIEZASAPAGAR { get; set; }
        public string U_SO1_REGALOPRECIO1 { get; set; } = null!;
        public string U_SO1_MANTENERDESC { get; set; } = null!;
    }
}
