using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.DataRO
{
    public partial class @SO1_01PERMISO
    {
        public string Code { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string? U_SO1_NOMBREPERMISO { get; set; }
        public string? U_SO1_MODULO { get; set; }
        public string? U_SO1_INGLES { get; set; }
        public string? U_SO1_VALORDEFECTO { get; set; }
        public string? U_SO1_FRANCES { get; set; }
        public string? U_SO1_PORTUGUES { get; set; }
        public string? U_SO1_ARABE { get; set; }
    }
}
