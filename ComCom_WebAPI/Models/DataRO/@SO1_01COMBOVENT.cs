using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.DataRO
{
    public partial class @SO1_01COMBOVENT
    {
        public string Code { get; set; } = null!;
        public string Name { get; set; } = null!;
        public DateTime? U_SO1_DESDE { get; set; }
        public DateTime? U_SO1_HASTA { get; set; }
        public string U_SO1_TIPO { get; set; } = null!;
        public decimal? U_SO1_CANTIDADSUJETA { get; set; }
        public decimal? U_SO1_CANTIDAREGALO { get; set; }
        public decimal? U_SO1_PORCENTAJEDES { get; set; }
        public string U_SO1_COMPORTAMIENTO { get; set; } = null!;
        public string U_SO1_ACUMULABLEREMO { get; set; } = null!;
        public string U_SO1_DEFINIRPOR { get; set; } = null!;
        public string? U_SO1_MONEDA { get; set; }
        public decimal? U_SO1_MONTOREGALO1 { get; set; }
        public decimal? U_SO1_MONTOREGALO2 { get; set; }
        public string U_SO1_FILTARALIANZA { get; set; } = null!;
        public short? U_SO1_LISTAPRECIO { get; set; }
        public short? U_SO1_NUMPIEZASMES { get; set; }
        public string? U_SO1_MENSAJEAPROXI1 { get; set; }
        public string? U_SO1_MENSAJEAPROXI2 { get; set; }
        public string U_SO1_UNICAMENTEMOST { get; set; } = null!;
        public decimal? U_SO1_PORCENTAJEDES2 { get; set; }
        public string U_SO1_COMPORTAAPLICA { get; set; } = null!;
        public string U_SO1_TIPODESCUENTO { get; set; } = null!;
        public int? U_SO1_DIASVIGENCIA { get; set; }
        public DateTime? U_SO1_FECHAVIGENCIA { get; set; }
        public string U_SO1_DEFINIRPORREGA { get; set; } = null!;
        public string? U_SO1_ARTICULOPREFRE { get; set; }
        public string U_SO1_ACUMPROMPUNTOS { get; set; } = null!;
        public string U_SO1_REGALOPRECIO1 { get; set; } = null!;
        public string U_SO1_PORCADA { get; set; } = null!;
    }
}
