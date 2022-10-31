using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.DataRO
{
    public partial class @SO1_01DEVOLCOMPRA
    {
        public string? Code { get; set; }
        public string Name { get; set; } = null!;
        public string? U_SO1_PROVEEDOR { get; set; }
        public DateTime? U_SO1_FECHA { get; set; }
        public short? U_SO1_HORA { get; set; }
        public string? U_SO1_HORACADENA { get; set; }
        public string? U_SO1_SUCURSAL { get; set; }
        public string? U_SO1_ESTACION { get; set; }
        public int? U_SO1_USUARIO { get; set; }
        public string U_SO1_STATUS { get; set; } = null!;
        public string? U_SO1_REFERENCIA { get; set; }
        public decimal? U_SO1_DESCUENTOACUM1 { get; set; }
        public decimal? U_SO1_DESCUENTOACUM2 { get; set; }
        public int? U_SO1_CONCEPTOGASTOS { get; set; }
        public decimal? U_SO1_IMPORTEGASTOS { get; set; }
        public decimal? U_SO1_GASTOSNETO { get; set; }
        public string? U_SO1_COMENTARIO { get; set; }
        public string? U_SO1_MONEDA { get; set; }
        public decimal? U_SO1_TIPOCAMBIO { get; set; }
        public decimal? U_SO1_DCTOPORCENTAJE { get; set; }
        public decimal? U_SO1_DCTOMONTO { get; set; }
        public decimal? U_SO1_TOTALNETO { get; set; }
        public decimal? U_SO1_TOTALNETOMONED { get; set; }
        public string? U_SO1_INDICAIMPUESTO { get; set; }
        public decimal? U_SO1_TASAIMPUESTO { get; set; }
        public string? U_SO1_FOLIOCORTEX { get; set; }
        public string? U_SO1_TIPODOCDESTINO { get; set; }
        public string? U_SO1_VERSIONR1 { get; set; }
        public int? U_SO1_PRELIMINARSBO { get; set; }
    }
}
