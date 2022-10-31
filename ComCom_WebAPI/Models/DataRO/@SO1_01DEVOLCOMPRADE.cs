using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.DataRO
{
    public partial class @SO1_01DEVOLCOMPRADE
    {
        public string? Code { get; set; }
        public string Name { get; set; } = null!;
        public string? U_SO1_FOLIO { get; set; }
        public short? U_SO1_NUMPARTIDA { get; set; }
        public string? U_SO1_NUMEROARTICULO { get; set; }
        public decimal? U_SO1_CANTIDAD { get; set; }
        public decimal? U_SO1_PBSD { get; set; }
        public decimal? U_SO1_PBCD { get; set; }
        public decimal? U_SO1_PNSD { get; set; }
        public decimal? U_SO1_PNCD { get; set; }
        public decimal? U_SO1_DESCUENTO { get; set; }
        public decimal? U_SO1_IMPUESTO { get; set; }
        public decimal? U_SO1_IMPORTENETO { get; set; }
        public string? U_SO1_MONEDA { get; set; }
        public decimal? U_SO1_TIPOCAMBIO { get; set; }
        public string? U_SO1_LISTAMAT { get; set; }
        public string U_SO1_ESPADRE { get; set; } = null!;
        public string U_SO1_TIPOLM { get; set; } = null!;
        public decimal? U_SO1_CANTIDADORIG { get; set; }
        public string? U_SO1_CODIGOALT { get; set; }
        public string? U_SO1_DOCUMENTOBASE { get; set; }
        public short? U_SO1_PARTIDABASE { get; set; }
        public string? U_SO1_COMENTARIOS { get; set; }
        public string? U_SO1_ALMACEN { get; set; }
        public string? U_SO1_INDICAIMPUESTO { get; set; }
        public decimal? U_SO1_TASAIMPUESTO { get; set; }
        public short? U_SO1_LISTAPRECIOS { get; set; }
        public string U_SO1_PRECIOMANUAL { get; set; } = null!;
        public string U_SO1_MEDIDAINVENTA { get; set; } = null!;
        public decimal? U_SO1_UNIDADCOMPRA { get; set; }
        public decimal? U_SO1_CANTIDADEMPAQ { get; set; }
        public short? U_SO1_CODIGOEMPAQ { get; set; }
        public string? U_SO1_CODIGODESEMPAQ { get; set; }
    }
}
