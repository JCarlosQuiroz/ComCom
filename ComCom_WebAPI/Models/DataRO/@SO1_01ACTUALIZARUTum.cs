using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.DataRO
{
    public partial class @SO1_01ACTUALIZARUTum
    {
        public string? Code { get; set; }
        public string? Name { get; set; }
        public short U_SO1_INSTACTUALIZA { get; set; }
        public string U_SO1_FOLIORUTA { get; set; } = null!;
        public string U_SO1_FOLIODOCUMENTO { get; set; } = null!;
        public short U_SO1_PARTIDA { get; set; }
        public decimal? U_SO1_DIFCANTIPEN { get; set; }
    }
}
