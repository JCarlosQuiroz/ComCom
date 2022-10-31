using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.DataRO
{
    public partial class @SO1_01SUBCUENTACOMA
    {
        public string? Code { get; set; }
        public string? Name { get; set; }
        public string? U_SO1_FOLIO { get; set; }
        public short? U_SO1_SUBCUENTA { get; set; }
        public decimal? U_SO1_TOTAL { get; set; }
        public string? U_SO1_DOCDESTINO { get; set; }
        public string? U_SO1_CLIENTE { get; set; }
        public string U_SO1_ESCREDITO { get; set; } = null!;
        public string U_SO1_ESENTREGA { get; set; } = null!;
    }
}
