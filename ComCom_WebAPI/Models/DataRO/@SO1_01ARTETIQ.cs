using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.DataRO
{
    public partial class @SO1_01ARTETIQ
    {
        public string Code { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string? U_SO1_ITEMCODE { get; set; }
        public string? U_SO1_ITEMNAME { get; set; }
        public string? U_SO1_CODEBAR { get; set; }
        public short? U_SO1_PRICELIST { get; set; }
        public decimal? U_SO1_PRECIO { get; set; }
        public string? U_SO1_MONEDA { get; set; }
        public string? U_SO1_IMPRESO { get; set; }
    }
}
