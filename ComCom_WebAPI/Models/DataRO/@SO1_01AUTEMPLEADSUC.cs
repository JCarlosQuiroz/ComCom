using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.DataRO
{
    public partial class @SO1_01AUTEMPLEADSUC
    {
        public string Code { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string? U_SO1_EMPLEADO { get; set; }
        public string? U_SO1_AUTORIZACION { get; set; }
        public string U_SO1_TIPO { get; set; } = null!;
        public string? U_SO1_SUCURSAL { get; set; }
        public string U_SO1_PERMITIDO { get; set; } = null!;
    }
}
