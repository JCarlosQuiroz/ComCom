using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.DataRO
{
    public partial class @SO1_01NUMTRANSACBAN
    {
        public string Code { get; set; } = null!;
        public string Name { get; set; } = null!;
        public DateTime? U_SO1_FECHA { get; set; }
        public string? U_SO1_ESTACION { get; set; }
        public short? U_SO1_NUMTRANSACCION { get; set; }
    }
}
