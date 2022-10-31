using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.DataRO
{
    public partial class @SO1_01ARTICOMPUESTO
    {
        public string Code { get; set; } = null!;
        public string Name { get; set; } = null!;
        public int U_SO1_CODIGO { get; set; }
        public int U_SO1_NIVEL { get; set; }
        public string U_SO1_DESCRIPCION { get; set; } = null!;
        public string? U_SO1_CODIGOARTICULO { get; set; }
        public int? U_SO1_PADRE { get; set; }
        public string? U_SO1_DISPARADOR { get; set; }
        public string? U_SO1_DISPARAPADRE { get; set; }
    }
}
