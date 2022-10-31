using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.DataRO
{
    public partial class @SO1_01PROMODESESC
    {
        public string Code { get; set; } = null!;
        public string Name { get; set; } = null!;
        public short? U_SO1_PROMOCION { get; set; }
        public string? U_SO1_PROMOCADENA { get; set; }
        public string U_SO1_CONIMPUESTO { get; set; } = null!;
        public string U_SO1_TIPO { get; set; } = null!;
        public string? U_SO1_ARTICULOSTODOS { get; set; }
    }
}
