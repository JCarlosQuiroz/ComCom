using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.DataRO
{
    public partial class @SO1_01VENDEPTOSUC
    {
        public string Code { get; set; } = null!;
        public string Name { get; set; } = null!;
        public int? U_SO1_VENDEDOR { get; set; }
        public short? U_SO1_DEPARTAMENTO { get; set; }
        public string? U_SO1_SUCURSAL { get; set; }
    }
}
