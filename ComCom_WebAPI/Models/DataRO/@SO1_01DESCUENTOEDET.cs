using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.DataRO
{
    public partial class @SO1_01DESCUENTOEDET
    {
        public string Code { get; set; } = null!;
        public int LineId { get; set; }
        public string? Object { get; set; }
        public int? LogInst { get; set; }
        public short? U_SO1_FABRICANTE { get; set; }
        public decimal? U_SO1_DESCUENTOEXCED { get; set; }
    }
}
