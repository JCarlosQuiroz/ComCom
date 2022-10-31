using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.DataRO
{
    public partial class @SO1_01CONTEOINVEDET
    {
        public string Code { get; set; } = null!;
        public string Name { get; set; } = null!;
        public short? U_SO1_NUMPARTIDA { get; set; }
        public string? U_SO1_NUMEROARTICULO { get; set; }
        public decimal? U_SO1_EXISTENCIA { get; set; }
        public decimal? U_SO1_CONTADO { get; set; }
        public decimal? U_SO1_DIFERENCIA { get; set; }
        public decimal? U_SO1_COSTO { get; set; }
        public string? U_SO1_MONEDA { get; set; }
        public string? U_SO1_CODIGOMUEBLE { get; set; }
        public string? U_SO1_NUMEROCONTEO { get; set; }
        public string U_SO1_MODIFICADO { get; set; } = null!;
        public string U_SO1_AGREGADOAUTO { get; set; } = null!;
    }
}
