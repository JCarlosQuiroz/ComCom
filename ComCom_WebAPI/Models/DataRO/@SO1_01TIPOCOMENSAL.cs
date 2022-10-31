using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.DataRO
{
    public partial class @SO1_01TIPOCOMENSAL
    {
        public string Code { get; set; } = null!;
        public string Name { get; set; } = null!;
        public short? U_SO1_PRIORIDAD { get; set; }
        public string? U_SO1_DESPORCOMENSAL { get; set; }
    }
}
