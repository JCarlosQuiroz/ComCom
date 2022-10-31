using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.DataRO
{
    public partial class @SO1_01USOCFDI
    {
        public string Code { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string? U_SO1_DESCRIPCION { get; set; }
        public string U_SO1_APLICAFISICA { get; set; } = null!;
        public string U_SO1_APLICAMORAL { get; set; } = null!;
    }
}
