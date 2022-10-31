using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.DataRO
{
    public partial class @SO1_01VENTATIEMPAIR
    {
        public string? Code { get; set; }
        public string Name { get; set; } = null!;
        public string? U_SO1_NUMTELEFONO { get; set; }
        public string? U_SO1_FECHATRANSAC { get; set; }
        public int? U_SO1_FOLIOTRANSAC { get; set; }
        public string? U_SO1_COMPANIATAE { get; set; }
        public string? U_SO1_LEYENDATAE { get; set; }
    }
}
