using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.DataRO
{
    public partial class @SO1_01CORTEXTRANSF
    {
        public string? Code { get; set; }
        public string? Name { get; set; }
        public int U_SO1_NUMTRANSFE { get; set; }
        public string? U_SO1_REFERENCIA { get; set; }
        public DateTime? U_SO1_FECHA { get; set; }
        public decimal U_SO1_MONTO { get; set; }
        public string U_SO1_FOLIO { get; set; } = null!;
        public int U_SO1_NUMLINEA { get; set; }
        public string? U_SO1_CODIFORMAPAGO { get; set; }
    }
}
