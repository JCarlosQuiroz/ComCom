using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.DataRO
{
    public partial class @SO1_01REGENTRASALI
    {
        public string? Code { get; set; }
        public string? Name { get; set; }
        public string U_SO1_CODEMPLEADO { get; set; } = null!;
        public DateTime U_SO1_FECHA { get; set; }
        public short U_SO1_HORA { get; set; }
        public string U_SO1_TIPO { get; set; } = null!;
        public string U_SO1_ESTATUS { get; set; } = null!;
        public string? U_SO1_HORACADENA { get; set; }
    }
}
