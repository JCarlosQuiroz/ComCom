using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.DataRO
{
    public partial class @SO1_01MONITOREOART
    {
        public string Code { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string? U_SO1_CATALOGO { get; set; }
        public string U_SO1_TIPO { get; set; } = null!;
        public string? U_SO1_ARTICULO { get; set; }
    }
}
