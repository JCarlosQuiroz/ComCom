using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.DataRO
{
    public partial class @SO1_01TICKETORDENBO
    {
        public string Code { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string? U_SO1_CODIGOTICKET { get; set; }
        public short? U_SO1_LINEA { get; set; }
        public string U_SO1_TIPO { get; set; } = null!;
        public string U_SO1_FUENTE { get; set; } = null!;
        public string? U_SO1_TEXTO { get; set; }
    }
}
