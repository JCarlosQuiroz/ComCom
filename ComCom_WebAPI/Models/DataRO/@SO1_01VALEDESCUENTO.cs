using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.DataRO
{
    public partial class @SO1_01VALEDESCUENTO
    {
        public string? Code { get; set; }
        public string Name { get; set; } = null!;
        public DateTime? U_SO1_FECHA { get; set; }
        public short? U_SO1_HORA { get; set; }
        public string? U_SO1_HORACADENA { get; set; }
        public string? U_SO1_SUCURSAL { get; set; }
        public string? U_SO1_ESTACION { get; set; }
        public string? U_SO1_STATUS { get; set; }
        public DateTime? U_SO1_FECHAVIGENCIA { get; set; }
        public string? U_SO1_FOLIOVENTA { get; set; }
        public decimal? U_SO1_DESCUENTO { get; set; }
        public string? U_SO1_CODIGOPROMO { get; set; }
        public DateTime? U_SO1_FECHAAPLICA { get; set; }
        public string? U_SO1_FOLIOAPLICA { get; set; }
        public string U_SO1_TIPODESCUENTO { get; set; } = null!;
        public string? U_SO1_POLITICAREDE { get; set; }
        public short? U_SO1_PROMOCION { get; set; }
        public string? U_SO1_VERSIONR1 { get; set; }
    }
}
