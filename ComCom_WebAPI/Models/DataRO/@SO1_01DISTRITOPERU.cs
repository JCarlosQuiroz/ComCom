using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.DataRO
{
    public partial class @SO1_01DISTRITOPERU
    {
        public string Code { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string? U_SO1_CODIGO { get; set; }
        public string? U_SO1_DESCRIPCION { get; set; }
        public string? U_SO1_PROVINCIA { get; set; }
        public string? U_SO1_DEPARTAMENTO { get; set; }
    }
}
