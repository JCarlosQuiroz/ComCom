using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.DataRO
{
    public partial class @SO1_01DEPOSITOBADET
    {
        public string? Code { get; set; }
        public string Name { get; set; } = null!;
        public string? U_SO1_FOLIO { get; set; }
        public short? U_SO1_NUMPARTIDA { get; set; }
        public string? U_SO1_FORMAPAGO { get; set; }
        public string? U_SO1_MONEDAFOPA { get; set; }
        public decimal? U_SO1_TCDIA { get; set; }
        public decimal? U_SO1_IMPORTEML { get; set; }
        public decimal? U_SO1_IMPORTEME { get; set; }
        public int? U_SO1_CUENTADESTINO { get; set; }
        public string? U_SO1_MONEDACUDE { get; set; }
        public decimal? U_SO1_TCAJUSTADO { get; set; }
        public decimal? U_SO1_DEPOSITOREAL { get; set; }
        public decimal? U_SO1_DIFERENCIACAMB { get; set; }
        public string? U_SO1_MONEDAASIENTO { get; set; }
        public string U_SO1_TIPODEPOSITO { get; set; } = null!;
        public string? U_SO1_COMENTARIOS { get; set; }
    }
}
