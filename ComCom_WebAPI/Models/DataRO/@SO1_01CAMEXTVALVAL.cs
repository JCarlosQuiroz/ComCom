using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.DataRO
{
    public partial class @SO1_01CAMEXTVALVAL
    {
        public string? Code { get; set; }
        public string? Name { get; set; }
        public string? U_SO1_CODIGOCAMPO { get; set; }
        public string U_SO1_CODIGOVALORVAL { get; set; } = null!;
        public string U_SO1_DESCVALORVALID { get; set; } = null!;
        public short? U_SO1_ORDEN { get; set; }
    }
}
