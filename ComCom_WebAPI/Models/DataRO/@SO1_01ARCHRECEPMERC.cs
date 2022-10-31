using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.DataRO
{
    public partial class @SO1_01ARCHRECEPMERC
    {
        public string Code { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string? U_SO1_CONCEPTO { get; set; }
        public int? U_SO1_NUMCARACT { get; set; }
        public string? U_SO1_IDENLINENCAB { get; set; }
        public string? U_SO1_IDENLINDETALL { get; set; }
    }
}
