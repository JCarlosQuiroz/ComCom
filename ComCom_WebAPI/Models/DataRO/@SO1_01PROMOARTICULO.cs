using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.DataRO
{
    public partial class @SO1_01PROMOARTICULO
    {
        public string Code { get; set; } = null!;
        public string Name { get; set; } = null!;
        public short? U_SO1_PROMOCION { get; set; }
        public string? U_SO1_PROMOCADENA { get; set; }
        public string U_SO1_TIPO { get; set; } = null!;
        public string? U_SO1_ARTICULO { get; set; }
        public decimal? U_SO1_IMPORTE { get; set; }
        public int? U_SO1_CODIGOAMBITO { get; set; }
    }
}
