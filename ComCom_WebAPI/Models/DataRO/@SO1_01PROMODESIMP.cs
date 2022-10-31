using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.DataRO
{
    public partial class @SO1_01PROMODESIMP
    {
        public string Code { get; set; } = null!;
        public string Name { get; set; } = null!;
        public short? U_SO1_PROMOCION { get; set; }
        public string? U_SO1_PROMOCADENA { get; set; }
        public string? U_SO1_COMPORTAMIENTO { get; set; }
        public string? U_SO1_MONEDA { get; set; }
        public decimal? U_SO1_MONTOMINIMO { get; set; }
        public decimal? U_SO1_IMPORTEDESC { get; set; }
    }
}
