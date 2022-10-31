using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.DataRO
{
    public partial class @SO1_01DINERODEPTO
    {
        public string? Code { get; set; }
        public string Name { get; set; } = null!;
        public string? U_SO1_FOLIO { get; set; }
        public short? U_SO1_NUMPARTIDA { get; set; }
        public string? U_SO1_CODIGODEPTO { get; set; }
        public string? U_SO1_ARTICULODEPTO { get; set; }
        public string? U_SO1_CODIGOIMPUESTO { get; set; }
        public decimal? U_SO1_TASAIMPUESTO { get; set; }
        public decimal? U_SO1_MONTOSINIMPUES { get; set; }
        public decimal? U_SO1_IMPUESTO { get; set; }
        public decimal? U_SO1_MONTONETO { get; set; }
    }
}
