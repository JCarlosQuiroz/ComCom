using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.DataRO
{
    public partial class @SO1_01MODMENUTOUCH
    {
        public string Code { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string? U_SO1_MODULO { get; set; }
        public string? U_SO1_SUBPANTALLA { get; set; }
        public string? U_SO1_CODIGOFUNCION { get; set; }
        public short? U_SO1_ORDEN { get; set; }
        public string? U_SO1_LENGUAJE { get; set; }
        public string? U_SO1_LENGUAJECORTO { get; set; }
        public string? U_SO1_IMAGEN { get; set; }
        public string U_SO1_ACCIONPRINCIP { get; set; } = null!;
    }
}
