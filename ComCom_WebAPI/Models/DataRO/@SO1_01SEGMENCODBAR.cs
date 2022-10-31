using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.DataRO
{
    public partial class @SO1_01SEGMENCODBAR
    {
        public string Code { get; set; } = null!;
        public string Name { get; set; } = null!;
        public short? U_SO1_ORDEN { get; set; }
        public string? U_SO1_DESCRIPCION { get; set; }
        public short? U_SO1_CARACTERES { get; set; }
    }
}
