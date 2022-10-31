using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.DataRO
{
    public partial class @SO1_01INFORMEVENTA
    {
        public string Code { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string? U_SO1_CLIENTE { get; set; }
        public string? U_SO1_ESTACION { get; set; }
        public string U_SO1_VISUALIZARPART { get; set; } = null!;
        public string U_SO1_FACTURAS { get; set; } = null!;
        public string U_SO1_REMISIONES { get; set; } = null!;
        public string U_SO1_NOTASCREDITO { get; set; } = null!;
        public string U_SO1_DEVOLUCIONES { get; set; } = null!;
        public string U_SO1_TIPOFACTURAS { get; set; } = null!;
    }
}
