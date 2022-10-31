using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.DataRO
{
    public partial class @SO1_01DATACAPTOKEN
    {
        public string Code { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string? U_SO1_CODIGOCLIENTE { get; set; }
        public string? U_SO1_NUMEROTARJETA { get; set; }
        public string? U_SO1_MARCATARJETA { get; set; }
        public string? U_SO1_SUCURSAL { get; set; }
        public DateTime? U_SO1_FECHAALTA { get; set; }
    }
}
