using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.DataRO
{
    public partial class @SO1_01COMBOVENTAPRE
    {
        public string Code { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string? U_SO1_CODIGO { get; set; }
        public short? U_SO1_LISTA { get; set; }
        public decimal? U_SO1_PRECIO { get; set; }
    }
}
