using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.DataRO
{
    public partial class @SO1_01TRASPASOSUCU
    {
        public string Code { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string? U_SO1_NOMBRE { get; set; }
        public string? U_SO1_CORREOELECTRON { get; set; }
        public string? U_SO1_REGION { get; set; }
        public string? U_SO1_TIPOSUCURSAL { get; set; }
        public int? U_SO1_FILIAL { get; set; }
        public string? U_SO1_CLIENTEMOSTRA { get; set; }
        public string? U_SO1_COLOR { get; set; }
        public string? U_SO1_ALMACRESGUARDO { get; set; }
    }
}
