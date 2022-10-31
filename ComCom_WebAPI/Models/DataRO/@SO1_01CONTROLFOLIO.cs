using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.DataRO
{
    public partial class @SO1_01CONTROLFOLIO
    {
        public string Code { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string? U_SO1_FOLIO { get; set; }
        public string? U_SO1_ESTACION { get; set; }
        public string? U_SO1_TIPO { get; set; }
        public string U_SO1_PROCESADO { get; set; } = null!;
    }
}
