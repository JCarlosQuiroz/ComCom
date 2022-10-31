using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.DataRO
{
    public partial class @SO1_01DESPACHO
    {
        public string? Code { get; set; }
        public string? Name { get; set; }
        public string U_SO1_FOLIODESP { get; set; } = null!;
        public string? U_SO1_FOLIOTRASP { get; set; }
        public string? U_SO1_ESTADO { get; set; }
        public string U_SO1_SINCRONIZA { get; set; } = null!;
    }
}
