using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.DataRO
{
    public partial class @SO1_01CAMEXTACTIVA
    {
        public string? Code { get; set; }
        public string? Name { get; set; }
        public string? U_SO1_CODIGOCAMPO { get; set; }
        public string U_SO1_PADRECRIACT { get; set; } = null!;
        public string U_SO1_ACTIVO { get; set; } = null!;
    }
}
