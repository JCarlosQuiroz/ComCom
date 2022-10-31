using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.DataRO
{
    public partial class @SO1_01FLUJOMONIPEST
    {
        public string Code { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string? U_SO1_CODIGOFLUJMONI { get; set; }
        public string? U_SO1_PESTANA { get; set; }
        public string? U_SO1_ACTIVO { get; set; }
        public string? U_SO1_ESTADOINICIAL { get; set; }
        public string? U_SO1_ESTADOFINAL { get; set; }
    }
}
