using System;
using System.Collections.Generic;

namespace ComCom_WebAPI.DataRO
{
    public partial class @SO1_01ORDENRECURR
    {
        public string? Code { get; set; }
        public string? Name { get; set; }
        public string U_SO1_LUNES { get; set; } = null!;
        public string U_SO1_MARTES { get; set; } = null!;
        public string U_SO1_MIERCOLES { get; set; } = null!;
        public string U_SO1_JUEVES { get; set; } = null!;
        public string U_SO1_VIERNES { get; set; } = null!;
        public string U_SO1_SABADO { get; set; } = null!;
        public string U_SO1_DOMINGO { get; set; } = null!;
        public short? U_SO1_HORALUNES { get; set; }
        public short? U_SO1_HORAMARTES { get; set; }
        public short? U_SO1_HORAMIERCOLES { get; set; }
        public short? U_SO1_HORAJUEVES { get; set; }
        public short? U_SO1_HORAVIERNES { get; set; }
        public short? U_SO1_HORASABADO { get; set; }
        public short? U_SO1_HORADOMINGO { get; set; }
    }
}
