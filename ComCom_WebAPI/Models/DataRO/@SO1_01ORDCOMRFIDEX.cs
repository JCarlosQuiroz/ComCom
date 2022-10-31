using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.DataRO
{
    public partial class @SO1_01ORDCOMRFIDEX
    {
        public string Code { get; set; } = null!;
        public string Name { get; set; } = null!;
        public int? U_SO1_DOCUMENTOSBO { get; set; }
        public string? U_SO1_NUMEROARTICULO { get; set; }
        public string? U_SO1_EPC { get; set; }
        public string? U_SO1_SUCURSAL { get; set; }
        public DateTime? U_SO1_FECHA { get; set; }
        public string U_SO1_ENCONTRADO { get; set; } = null!;
        public int? U_SO1_NUMERODOCTOSBO { get; set; }
        public string? U_SO1_FOLIOR1 { get; set; }
        public int? U_SO1_PARTIDASBO { get; set; }
    }
}
