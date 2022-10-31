using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.DataRO
{
    public partial class @SO1_01POREDARTIFABR
    {
        public string Code { get; set; } = null!;
        public string Name { get; set; } = null!;
        public short? U_SO1_POLITICAREDEN { get; set; }
        public string? U_SO1_POREDCADENA { get; set; }
        public short? U_SO1_FABRICANTE { get; set; }
        public string U_SO1_ACTIVO { get; set; } = null!;
    }
}
