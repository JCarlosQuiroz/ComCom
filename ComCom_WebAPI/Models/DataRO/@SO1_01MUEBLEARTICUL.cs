using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.DataRO
{
    public partial class @SO1_01MUEBLEARTICUL
    {
        public string? Code { get; set; }
        public string Name { get; set; } = null!;
        public string? U_SO1_CODIGOMUEBLE { get; set; }
        public string? U_SO1_ARTICULO { get; set; }
        public string? U_SO1_UBICACION { get; set; }
        public int? U_SO1_NUMEROLINEA { get; set; }
    }
}
