using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.DataRO
{
    public partial class @SO1_01PROMOAMBITO
    {
        public string Code { get; set; } = null!;
        public string Name { get; set; } = null!;
        public short? U_SO1_PROMOCION { get; set; }
        public string? U_SO1_PROMOCADENA { get; set; }
        public int? U_SO1_CODIGOAMBITO { get; set; }
        public string? U_SO1_NOMBREAMBITO { get; set; }
        public decimal? U_SO1_CANTIDAD { get; set; }
        public string? U_SO1_IMAGEN { get; set; }
        public string? U_SO1_MANTENERPROMO { get; set; }
        public string? U_SO1_AMBOBLIGATORIO { get; set; }
    }
}
