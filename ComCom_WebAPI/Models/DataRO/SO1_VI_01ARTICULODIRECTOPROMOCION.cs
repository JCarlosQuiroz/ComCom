using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.DataRO
{
    public partial class SO1_VI_01ARTICULODIRECTOPROMOCION
    {
        public short? U_SO1_PROMOCION { get; set; }
        public string? U_SO1_ARTICULO { get; set; }
        public string U_SO1_TIPOARTICULO { get; set; } = null!;
        public int? U_SO1_CODIGOAMBITO { get; set; }
        public decimal? U_SO1_IMPORTE { get; set; }
    }
}
