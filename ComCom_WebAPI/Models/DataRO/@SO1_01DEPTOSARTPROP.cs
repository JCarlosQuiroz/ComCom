using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.DataRO
{
    public partial class @SO1_01DEPTOSARTPROP
    {
        public string Code { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string U_SO1_ESDEPARTAMENTO { get; set; } = null!;
        public string? U_SO1_ARTICULOCOMISI { get; set; }
        public string U_SO1_ACTIVO { get; set; } = null!;
        public decimal? U_SO1_FACTOR { get; set; }
        public decimal? U_SO1_PERMITIDO { get; set; }
    }
}
