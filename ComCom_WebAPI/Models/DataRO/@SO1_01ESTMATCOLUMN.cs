using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.DataRO
{
    public partial class @SO1_01ESTMATCOLUMN
    {
        public string Code { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string? U_SO1_ESTACION { get; set; }
        public string? U_SO1_MATRIZ { get; set; }
        public string? U_SO1_COLUMNA { get; set; }
        public string? U_SO1_DESCRIPCION { get; set; }
        public string? U_SO1_ACTIVO { get; set; }
        public short? U_SO1_ORDEN { get; set; }
    }
}
