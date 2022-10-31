using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.DataRO
{
    public partial class @SO1_01COMBOVENTALI
    {
        public string Code { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string? U_SO1_CODIGO { get; set; }
        public int? U_SO1_CODIGOLISTA { get; set; }
        public int? U_SO1_CANTIDADINI { get; set; }
    }
}
