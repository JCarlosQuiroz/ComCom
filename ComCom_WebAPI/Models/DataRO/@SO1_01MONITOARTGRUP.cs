using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.DataRO
{
    public partial class @SO1_01MONITOARTGRUP
    {
        public string Code { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string? U_SO1_CATALOGO { get; set; }
        public short? U_SO1_GRUPO { get; set; }
        public string U_SO1_ACTIVO { get; set; } = null!;
    }
}
