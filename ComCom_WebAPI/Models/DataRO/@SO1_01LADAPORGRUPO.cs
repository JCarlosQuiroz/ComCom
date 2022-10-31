using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.DataRO
{
    public partial class @SO1_01LADAPORGRUPO
    {
        public string Code { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string? U_SO1_CODIGOGRPLAD { get; set; }
        public string? U_SO1_LADA { get; set; }
        public short? U_SO1_ORDENLADA { get; set; }
    }
}
