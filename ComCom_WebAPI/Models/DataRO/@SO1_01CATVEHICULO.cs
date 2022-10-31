using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.DataRO
{
    public partial class @SO1_01CATVEHICULO
    {
        public string Code { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string? U_SO1_NOMBRE { get; set; }
        public string? U_SO1_IDCHOFER { get; set; }
        public decimal? U_SO1_PESO { get; set; }
        public string? U_SO1_SUCURSAL { get; set; }
    }
}
