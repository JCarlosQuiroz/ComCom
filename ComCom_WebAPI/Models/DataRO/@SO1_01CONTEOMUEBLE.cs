using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.DataRO
{
    public partial class @SO1_01CONTEOMUEBLE
    {
        public string? Code { get; set; }
        public string Name { get; set; } = null!;
        public string? U_SO1_FOLIO { get; set; }
        public string? U_SO1_CODIGOMUEBLE { get; set; }
        public string? U_SO1_NUMEROCONTEO { get; set; }
        public DateTime? U_SO1_FECHA { get; set; }
        public short? U_SO1_HORA { get; set; }
        public string? U_SO1_HORACADENA { get; set; }
        public string? U_SO1_ESTACION { get; set; }
        public int? U_SO1_USUARIO { get; set; }
        public string U_SO1_STATUS { get; set; } = null!;
        public string U_SO1_AJUSTADO { get; set; } = null!;
    }
}
