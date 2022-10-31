using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.DataRO
{
    public partial class @SO1_01RUTum
    {
        public string? Code { get; set; }
        public string Name { get; set; } = null!;
        public DateTime? U_SO1_FECHACREACION { get; set; }
        public short? U_SO1_HORACREACION { get; set; }
        public string? U_SO1_HORACREACADENA { get; set; }
        public int? U_SO1_USUARIO { get; set; }
        public string? U_SO1_ESTADO { get; set; }
        public string? U_SO1_VEHICULO { get; set; }
        public string? U_SO1_TRANSPORTISTA { get; set; }
        public DateTime? U_SO1_FECHAFIN { get; set; }
        public short? U_SO1_HORAFIN { get; set; }
        public string? U_SO1_HORAFINCADENA { get; set; }
        public DateTime? U_SO1_FECHAACTUALIZA { get; set; }
        public decimal? U_SO1_PESOTOTAL { get; set; }
        public string? U_SO1_SUCURSAL { get; set; }
        public string? U_SO1_ESTACION { get; set; }
        public string? U_SO1_VERSIONR1 { get; set; }
        public decimal? U_SO1_KILOMEINICIO { get; set; }
        public decimal? U_SO1_KILOMEFIN { get; set; }
        public short? U_SO1_INSTACTUALIZA { get; set; }
        public string? U_SO1_FOLIOCORTEX { get; set; }
    }
}
