using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.DataRO
{
    public partial class @SO1_01CORTEDENOMINA
    {
        public string? Code { get; set; }
        public string Name { get; set; } = null!;
        public string? U_SO1_FOLIOCORTEX { get; set; }
        public string? U_SO1_FORMAPAGO { get; set; }
        public int? U_SO1_NUMEROLINEA { get; set; }
        public string? U_SO1_DESCRIPCION { get; set; }
        public int? U_SO1_CANTIDAD { get; set; }
        public decimal? U_SO1_MONTO { get; set; }
        public decimal? U_SO1_IMPORTE { get; set; }
    }
}
