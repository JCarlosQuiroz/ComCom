using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.DataRO
{
    public partial class @SO1_01MODEMPROL
    {
        public string? Code { get; set; }
        public string? Name { get; set; }
        public string? U_SO1_CODIGOMODULO { get; set; }
        public string U_SO1_PERMITIDO { get; set; } = null!;
        public string? U_SO1_CODIEMPROL { get; set; }
    }
}
