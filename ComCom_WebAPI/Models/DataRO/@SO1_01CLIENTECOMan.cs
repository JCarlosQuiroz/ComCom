using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.DataRO
{
    public partial class @SO1_01CLIENTECOMan
    {
        public string? Code { get; set; }
        public string? Name { get; set; }
        public short? U_SO1_COMENSAL { get; set; }
        public string? U_SO1_CLIENTE { get; set; }
        public string? U_SO1_CONDPAGO { get; set; }
        public string? U_SO1_FOLIO { get; set; }
        public string U_SO1_ESENTREGA { get; set; } = null!;
        public short? U_SO1_CONDICIONPAGO { get; set; }
        public string? U_SO1_FOLIOESPERA { get; set; }
        public string U_SO1_CLIENTEALTERNO { get; set; } = null!;
        public string? U_SO1_TIPOCOMENSAL { get; set; }
        public string? U_SO1_NOMBRECLIENTE { get; set; }
    }
}
