using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.DataRO
{
    public partial class @SO1_01COBRODOMICILI
    {
        public string? Code { get; set; }
        public string Name { get; set; } = null!;
        public DateTime? U_SO1_FECHA { get; set; }
        public short? U_SO1_HORA { get; set; }
        public string? U_SO1_HORACADENA { get; set; }
        public string? U_SO1_SUCURSAL { get; set; }
        public string? U_SO1_ESTACION { get; set; }
        public int? U_SO1_USUARIO { get; set; }
        public decimal? U_SO1_MONTOTOTAL { get; set; }
        public string? U_SO1_MONEDA { get; set; }
        public decimal? U_SO1_TIPOCAMBIO { get; set; }
        public string? U_SO1_FOLIOCORTEX { get; set; }
        public string? U_SO1_VERSIONR1 { get; set; }
    }
}
