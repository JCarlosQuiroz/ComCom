using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.DataRO
{
    public partial class @SO1_01DEFINIMATRIZ
    {
        public string Code { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string? U_S01_TIPO { get; set; }
        public short? U_SO1_POSICIONCOLUM { get; set; }
        public string? U_SO1_ENCABEZADO { get; set; }
        public string? U_SO1_TIPOANCHO { get; set; }
        public short? U_SO1_ANCHOCOLUMNA { get; set; }
        public short? U_SO1_MINIMOANCHO { get; set; }
        public string? U_SO1_TIPODATO { get; set; }
        public string? U_SO1_LENGUAJE { get; set; }
    }
}
