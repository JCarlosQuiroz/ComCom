using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.DataRO
{
    public partial class @SO1_01VENTAPROPINA
    {
        public string? Code { get; set; }
        public string Name { get; set; } = null!;
        public decimal? U_SO1_MONTOPROPINA { get; set; }
        public decimal? U_SO1_PORCENPROPINA { get; set; }
        public string? U_SO1_CODIGOFP { get; set; }
    }
}
