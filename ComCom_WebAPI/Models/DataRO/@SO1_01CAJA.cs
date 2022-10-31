using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.DataRO
{
    public partial class @SO1_01CAJA
    {
        public string? Code { get; set; }
        public string? Name { get; set; }
        public int U_SO1_IDCAJA { get; set; }
        public string? U_SO1_FOLIOCAJA { get; set; }
        public int? U_SO1_NOCAJA { get; set; }
        public string? U_SO1_FOLIO { get; set; }
        public DateTime? U_SO1_FECHA { get; set; }
        public int? U_SO1_HORA { get; set; }
        public string? U_SO1_HORACADENA { get; set; }
        public string? U_SO1_USUARIO { get; set; }
        public string? U_SO1_TRASPSEPARA { get; set; }
        public string? U_SO1_ESTADO { get; set; }
        public string? U_SO1_FOLTRASPDIR { get; set; }
        public string? U_SO1_IMPRESO { get; set; }
        public string U_SO1_SINCRONIZA { get; set; } = null!;
    }
}
