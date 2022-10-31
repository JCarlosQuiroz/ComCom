using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.DataRO
{
    public partial class @SO1_01TICKETDETBOL
    {
        public string Code { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string? U_SO1_CODIGOTICKET { get; set; }
        public string U_SO1_CATEGORIA { get; set; } = null!;
        public short? U_SO1_LINEA { get; set; }
        public short? U_SO1_ORDEN { get; set; }
        public string U_SO1_DATO { get; set; } = null!;
        public string? U_SO1_TEXTO { get; set; }
        public short? U_SO1_CARACTERES { get; set; }
        public string U_SO1_ALINEACION { get; set; } = null!;
    }
}
