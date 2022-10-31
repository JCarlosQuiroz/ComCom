using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.DataRO
{
    public partial class @SO1_01ARTICURESTAU
    {
        public string Code { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string? U_SO1_PADRE { get; set; }
        public string U_SO1_TIPO { get; set; } = null!;
        public string? U_SO1_ARTICULO { get; set; }
        public string? U_SO1_IMAGEN { get; set; }
        public string? U_SO1_AREAIMPRES { get; set; }
        public short? U_SO1_PRIORIDAD { get; set; }
        public string? U_SO1_CATALOGOMENU { get; set; }
    }
}
