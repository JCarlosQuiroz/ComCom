using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.DataRO
{
    public partial class @SO1_01BITACOPUNTO
    {
        public string? Code { get; set; }
        public string? Name { get; set; }
        public string? U_SO1_MEMBRESIA { get; set; }
        public DateTime? U_SO1_FECHA { get; set; }
        public short? U_SO1_HORA { get; set; }
        public string U_SO1_TIPO { get; set; } = null!;
        public string? U_SO1_FOLIO { get; set; }
        public int? U_SO1_PUNTOSINICIO { get; set; }
        public int? U_SO1_PUNTOSOBTENIDO { get; set; }
        public int? U_SO1_PUNTOSUTILIZA { get; set; }
        public int? U_SO1_PUNTOSFINALES { get; set; }
        public int? U_SO1_USUARIO { get; set; }
    }
}
