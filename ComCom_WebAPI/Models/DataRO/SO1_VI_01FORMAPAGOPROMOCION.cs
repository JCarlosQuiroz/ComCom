using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.DataRO
{
    public partial class SO1_VI_01FORMAPAGOPROMOCION
    {
        public short? U_SO1_PROMOCION { get; set; }
        public string? U_SO1_FORMAPAGO { get; set; }
        public decimal? U_SO1_MINIMO { get; set; }
        public string U_SO1_TIPO { get; set; } = null!;
    }
}
